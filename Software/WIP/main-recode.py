from pycaw.pycaw import AudioUtilities
import serial
import yaml
import os
import serial.tools.list_ports
import logging
import sys
from defaults import default_yaml

logging.basicConfig(stream=sys.stderr, level=logging.DEBUG)
logger = logging.getLogger(__name__)
config_file_path = "config.yaml"


def error_factory(exception, message):
    return exception(message)


class Config:
    potential_yes = ["y", "yes", 1]

    def __init__(self, file=config_file_path):
        if not os.path.isfile(file):
            with open('config.yaml', 'w') as new_yaml:
                yaml.dump(default_yaml, new_yaml)
        with open(file, encoding='UTF-8') as file:
            config = yaml.safe_load(file)

        self.comport = config.get('comport', default_yaml['comport'])
        self.baudrate = config.get('baudrate', default_yaml['baudrate'])
        self.bytesize = config.get('bytesize', default_yaml['bytesize'])
        self.parity = config.get('parity', default_yaml['parity'])
        self.stopbits = config.get('stopbits', default_yaml['stopbits'])
        self.vm = True if config.get('VM', default_yaml['VM']).lower() in self.potential_yes else False
        self.vm_version = config.get('VM-Version', default_yaml['VM-Version'])
        self.mappings = config.get('Mappings', default_yaml['Mappings'])

        for ID in self.mappings:
            for key in self.mappings[ID]:
                value = None
                if self.mappings[ID][key]:
                    value = (self.mappings[ID][key]).split(";")
                self.mappings[ID][key] = value


class AudioController:

    def __init__(self, process_name):
        self.process_name = process_name
        self.volume = self.process_volume()

    def mute(self):
        sessions = AudioUtilities.GetAllSessions()
        for session in sessions:
            interface = session.SimpleAudioVolume
            if session.Process and session.Process.name() == self.process_name:
                interface.SetMute(1, None)
                logging.info('%s has been muted.', self.process_name)

    def process_volume(self):
        sessions = AudioUtilities.GetAllSessions()
        for session in sessions:
            interface = session.SimpleAudioVolume
            if session.Process and session.Process.name() == self.process_name:
                logging.info('Volume %d', interface.GetMasterVolume())
                return interface.GetMasterVolume()

    def set_volume(self, decibels):

        sessions = AudioUtilities.GetAllSessions()

        for session in sessions:
            interface = session.SimpleAudioVolume
            if session.Process and session.Process.name() == self.process_name:
                # only set volume in the range 0.0 to 1.0
                self.volume = min(1.0, max(0.0, decibels))
                interface.SetMasterVolume(self.volume, None)
                logging.info('Volume set to %d', self.volume)


class HaMixer:

    def __init__(self, config):
        self.config = config
        self.s = serial.Serial()
        self.s.port = config.comport
        self.s.baudrate = config.baudrate
        self.s.bytesize = config.bytesize
        self.s.parity = config.parity
        self.s.stopbits = config.stopbits
        self.is_open = None
        if not any(self.s.port in port.name for port in serial.tools.list_ports.comports()):
            logging.error("Port %s Not Found", self.s.port)
            raise error_factory(IOError, "Port %s Not Found" % self.s.port)

        logging.info("Found Port %s", self.s.port)
        if self.s.isOpen():
            logging.error("Port %s Already Open", self.s.port)
            raise error_factory(IOError, "Port %s Already Open" % self.s.port)
        try:
            logging.info("Opening Port %s", self.s.port)
            self.s.open()
            logging.info("Opened Port %s", self.s.port)
            self.is_open = self.s.port
        except IOError:
            logging.error("Error Opening Port %s", self.s.port)
            raise error_factory(IOError, "Error Opening Port %s" % self.s.port)

    def poll(self):
        receive = str(self.s.readline()).strip(r'xb').strip(r"\\n'").lstrip(r"'")
        return receive

    def ham_main(self):
        while self.is_open:
            receive = self.poll()
            volume, channel = receive.split("@")
            volume = int(volume)
            volume = round(volume / 100, 2)
            try:
                for app in self.config.mappings["ID" + channel]["Applications"]:
                    logging.debug(app)
                    control = AudioController(app)
                    control.set_volume(volume)
            except TypeError:
                pass


def main():
    config = Config()
    ham = HaMixer(config)
    ham.ham_main()


if __name__ == "__main__":
    main()
