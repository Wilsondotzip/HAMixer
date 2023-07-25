from pycaw.pycaw import AudioUtilities, ISimpleAudioVolume
import serial
import yaml
import sys
import os
import serial.tools.list_ports
import atexit


def equit(veme):
    if veme==1:
        vmr.logout()

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
    sys.exit()
s.baudrate=config['baudrate']
s.bytesize=config['bytesize']
s.parity=config['parity']
s.stopbits=config['stopbits']
veme=0
VME=False
if config['VM']=='Y':
    VME=True
if VME:
    import voicemeeter
    kind_id=config['VM-Version']
    vmr=voicemeeter.remote(kind_id)
    vmr.login()
    def sgainch(srep,num):
        srep=int(srep)
        num=int(num)/100
        if num<0.5:
            fnum=(0.5-num)*-120
        elif num>0.5:
            fnum=(num-0.5)*24
        else: fnum=0
        #print(srep,num,fnum)
        vmr.inputs[srep].gain=int(fnum)
    def bgainch(srep,num):
        srep=int(srep)
        num=int(num)/100
        if num<0.5:
            fnum=(0.5-num)*-120
        elif num>0.5:
            fnum=(num-0.5)*24
        else: fnum=0
        #print(srep,num,fnum)
        vmr.outputs[srep].gain=int(fnum)
    veme=1
ie=0
ids={}
for a in config['Mappings']:
    num=int(a.lower().strip('id'))
    fcen=config['Mappings'][a]
    appes=fcen['Applications']
    lt={}
    lele=[]
    if VME:
        if 'VM' in fcen:
            if fcen['VM']!=None:
                lele.append(fcen['VM'])
            lt.update({'vm':lele})
    if appes!=None:
        appes=appes.split(';')
        lte=[]
        for a in appes:
            lte.append(a)
        lt.update({'aps':lte})
    if lt!={}:
        temp={num:lt}
        ids.update(temp)
idv={}
for a in ids:
    temp={a:0}
    idv.update(temp)
print(ids)
#print(idv)
def main():
    called=0
    while True:
        try:
            f=str(s.readline()).strip('xb').strip("\\n'").lstrip("'")
        except:
            print('disconnect error')
            sys.exit()
        #print(f)
        e=f.split('@')
        try:
            e[0]=int(e[0])
        except:
            print('speed error')
        try:
            e[1]=int(e[1])
        except:
            print('speed error part 2')
            return main()
        if e[1] in idv:
            if e[0]!=idv[e[1]]:
                #print(e[0],idv[e[1]],'----------')#debug
                idv[e[1]]=e[0]
                sessions = AudioUtilities.GetAllSessions()
                for session in sessions:
                    volume = session._ctl.QueryInterface(ISimpleAudioVolume)
                    if veme==0:
                        if 'aps' in ids[e[1]]:
                            for a in ids[e[1]]['aps']:
                                if session.Process and session.Process.name() == a:
                                    #print("volume.GetMasterVolume(): %s" % volume.GetMasterVolume(),ids[e[1]]) debug
                                    volume.SetMasterVolume(round(idv[e[1]]/100,2), None)
                    if 'vm' in ids[e[1]]:
                        for a in ids[e[1]]['vm']:
                            if called==0:
                                if a.lower().startswith('input'):
                                    num=a.strip('Input')
                                    sgainch(num,idv[e[1]])
                                if a.lower().startswith('output'):
                                    num=a.strip('Output')
                                    bgainch(num,idv[e[1]])
                                called=called+1
                            else:
                                called=called+1
                                if called>=5:
                                    called=0
                                    
atexit.register(equit,veme=veme)                                

if __name__ == "__main__":
    main()
