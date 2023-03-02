from pycaw.pycaw import AudioUtilities, ISimpleAudioVolume
import serial
import yaml
import sys
import os
import serial.tools.list_ports
defaultcom=''
for port in serial.tools.list_ports.comports():
    if 'arduino' in port.description.lower():
        defaultcom=port.device
with open('config.yaml','r',encoding='UTF-8') as e:
    config=yaml.safe_load(e)
    e.close()
if config['comport']=='COM':
    #print(defaultcom)
    ccomport=defaultcom
else:
    ccomport=str(config['comport'])
serialport=ccomport
try:
    s=serial.Serial(serialport)
except:
    quit()
s.baudrate=config['baudrate']
s.bytesize=config['bytesize']
s.parity=config['parity']
s.stopbits=config['stopbits']
ie=0
ids={}
for a in config['Mappings']:
    #print(a)
    num=int(a.lower().strip('id'))
    appes=config['Mappings'][a]['Applications']
    if appes!=None:
        appes=appes.split(';')
        temp={num:appes}
        ids.update(temp)
idv={}
for a in ids:
    temp={a:0}
    idv.update(temp)
#print(ids)
#print(idv)
while True:
    try:
        f=str(s.readline()).strip('xb').strip("\\n'").lstrip("'")
    except:
        quit()
    print(f)
    e=f.split('@')
    try:
        if e[1] in idv:
            if e[0]!=idv[e[1]]:
                #print(e[0],idv[e[1]],'----------')#debug
                idv[e[1]]=e[0]
                sessions = AudioUtilities.GetAllSessions()
                for session in sessions:
                    volume = session._ctl.QueryInterface(ISimpleAudioVolume)
                    for a in ids[e[1]]:
                        if session.Process and session.Process.name() == a:
                            #print("volume.GetMasterVolume(): %s" % volume.GetMasterVolume(),ids[e[1]]) debug
                            volume.SetMasterVolume(round(idv[e[1]]/100,2), None)
    except:
        print('speed error the final part')
