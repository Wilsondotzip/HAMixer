# VolumeMaster - *HardwareApplicationMixer*
VolumeMaster is a hardware application mixer for changing the volume of different  windows apps on the fly. No more digging through menus. Easily adjust the volume of your music, voice chat or game to be just how you like it.  This project is still in active development you can see all the features we plan to add [here](#what's-to-come) and if you have any feedback or requests don't hesitate to log an issue.

Recently rebranded to VolumeMaster not all docs are up to date.

## Check out the Wiki For build guides and FAQ!

![1nonsquare](https://github.com/Wilsondotzip/HAMixer/assets/58171274/fa879564-af6d-4e54-b166-ebcadf9d83df)

# Contents:
### [Getting Started](#getting-started)
 - [How things work](#how-things-work)
 - [Requirements](#requirements)
 ### [Features ](#features)
 - [Whats here](#features)
 - [Whats to come](#whats-to-come)
   
# Getting Started:

## How things work
A Python script runs in the background to turn the Arduino's serial inputs into volume changes. The Arduino reads each potentiometer as a separate analogue input, this information (once mapped between [0,100]) is then sent to your computer over a COM port. The python program runs to receive the information and convert it to meaningful volume commands!  below is an image of the DIY version. 

![Image2](https://user-images.githubusercontent.com/58171274/208288002-e05144c8-9d7c-4ace-b45a-9c51406f2135.jpg)

## Requirements
Currently only **Windows** is tested and supported to work. Adding Linux support is something high on our priority list.
If you have windows you're all set nothing else is needed! Go grab the [latest release](https://github.com/Wilsondotzip/HAMixer/releases) and run it inside its own folder with the config file. You can run either the GUI or headless version.

Alternatively  you can use the [source code](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Software/Source) instead. 



# Features

- Map an application's volume to a specific control knob
- Application grouping, to have multiple applications controlled by one knob
- Full Windows GUI, for easy setup and application mapping!
- When minimized, software which runs quietly in the background as a tray icon
- Easy to use config files
- Auto reconnect
- System notifications when things go wrong
- A headless software varient
- Full Windows support
- VoiceMeeter integration, control voicemeeter tracks with your HAMixer! *Please note this feature is still in developement and is currently SLOW but useable, we are working to solve this.*
- 
## What’s to come...
This project is still in active development, so here are some of the features we plan to add in the future.

- Linux support. Its getting there... (We will need to remake the backend script from the ground up for this.)
- More cases! I mean more! All of the cases, every case. Front controls top controls you name it!
- A pretty UI that has easy to customize colours.
- Verified firmware support for other microcontrollers, not everyone has an Arduino Uno. How about an Arduino Micro, or ESP?
- Not yet sure how to do this one but somewhere down the line we would like to add control over hardware devices like microphones and speakers.
- Buttons for possible functions like muting and config switching. 
- In the long run It would be great to have a custom PCB, to make easy to build kits possible.
- Have an idea? Let us know. 


