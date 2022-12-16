from pycaw.pycaw import AudioUtilities, ISimpleAudioVolume
import serial
s=serial.Serial('COM3')
s.baudrate=9600
s.bytesize=8
s.parity='N'
s.stopbits=1
ids={1:'chrome.exe',2:'',3:'',4:''}
idv={}
for a in ids:
    temp={a:0}
    idv.update(temp)
def main():
    while True:
        f=str(s.readline()).strip('xb').strip("\\n'").lstrip("'")
        e=f.split('@')
        try:
            e[0]=int(e[0])
        except:
            print('speed error')
            return main()
        e[1]=int(e[1])
        if e[0]!=idv[e[1]]:
            idv[e[1]]=e[0]
            sessions = AudioUtilities.GetAllSessions()
            for session in sessions:
                volume = session._ctl.QueryInterface(ISimpleAudioVolume)
                if session.Process and session.Process.name() == ids[e[1]]:
                    volume.SetMasterVolume(round(e[0]/100,2), None)
main()
