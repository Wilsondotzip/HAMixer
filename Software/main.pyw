from pycaw.pycaw import AudioUtilities, ISimpleAudioVolume
import serial
import yaml
import pystray
import PIL.Image
import sys
import threading
global satop
satop=0
image=PIL.Image.open('icon.ico')
def on_clicked(icon,item):
    global satop
    if str(item)=='close':
        satop=1
        icon.stop()
        sys.exit(0)
        
icon=pystray.Icon('HAM',image,menu=pystray.Menu(
    pystray.MenuItem('close',on_clicked)
))
with open('config.yaml','r') as e:
    config=yaml.load(e,Loader=yaml.FullLoader)
serialport='COM'+str(config['comport'])
s=serial.Serial(serialport)
s.baudrate=config['baudrate']
s.bytesize=config['bytesize']
s.parity=config['parity']
s.stopbits=config['stopbits']
ie=0
ids={}
for a in config['IDs']:
    ie=ie+1
    temp={ie:a}
    ids.update(temp)
idv={}
for a in ids:
    temp={a:0}
    idv.update(temp)
def main():
    global satop
    while satop!=1:
        f=str(s.readline()).strip('xb').strip("\\n'").lstrip("'")
        e=f.split('@')
        try:
            e[0]=int(e[0])
        except:
            print('speed error')
            return main()
        try:
            e[1]=int(e[1])
        except:
            print('speed error part 2')
            return main()
        if e[1]>len(ids):
            return main()
        if e[0]!=idv[e[1]]:
            #print(e[0],idv[e[1]],'----------') debug
            idv[e[1]]=e[0]
            sessions = AudioUtilities.GetAllSessions()
            for session in sessions:
                volume = session._ctl.QueryInterface(ISimpleAudioVolume)
                if session.Process and session.Process.name() == ids[e[1]]:
                    #print("volume.GetMasterVolume(): %s" % volume.GetMasterVolume(),ids[e[1]]) debug
                    volume.SetMasterVolume(round(idv[e[1]]/100,2), None)
IconThread=threading.Thread(target=icon.run,name='HAM.icon')
IconThread.start()
main()
