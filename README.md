# HardwareApplicationMixer
HAM is a hardware application mixer for changing the volume of diferent windows apps on the fly. No more digging through menus. Easily adjust the volume of your music, voice chat or game to be just how you like it.  This project is still in active developement you can see all the features we plan to add here.

![Image1](https://user-images.githubusercontent.com/58171274/208287616-4ac56eff-1d69-4b42-90ca-15974aa2479a.jpg)

# Contents:
### [Getting Started](#getting-started)
 - [How things work](#how-things-work)
 - [Requirements](#requirements)
 - [Using config files](#using-config-files)
 - [How to build your own](#how-to-build-your-own)
    - [BOM](#BOM)
### [Features](#features)
 - [Whats here](#whats-here)
 - [Whats to come](#whats-to-come)
### FAQ
 - [How do I know what COM port to use?](#how-do-i-know-what-com-port-to-use)


# Getting Started:

## How things work
A Python script runs in the background to turn the Arduino's serial inputs into volume changes. The Arduino reads each potentiometer as a separate analogue input, this information (once mapped between [0,100]) is then sent to your computer over a COM port. The python program runs to receive the information and convert it to meaningful volume commands!  

![Image2](https://user-images.githubusercontent.com/58171274/208288002-e05144c8-9d7c-4ace-b45a-9c51406f2135.jpg)

## Requirements
Currently only **Windows** is tested and supported to work. Adding Linux support is something high on our priority list.
If you have windows you're all set nothing else is needed! Go grab the [compiled exe](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Software) and run it inside its own folder with the config file. 

Alternativly you can use the [source code](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Software/Source) instead. 

## Using config files
Configuration files are mainly used to bind applications to potentiometers and define the COM your HAM is connected to. A config file is needed in order to run the HAM software, so make sure your config.yaml file is in the same directory. Config files are written using YAML, here's the default config file:
```YAML
comport: 4
IDs: ## You can add up to 4 (depending on how many control knobs you have). Top to bottom -> left to right on your HAM device 
- chrome.exe
- steam.exe
- Discord.exe
- vlc.exe

baudrate: 9600 ## Must match firmware baudrate. 

bytesize: 8
parity:  N
stopbits: 1

```
1. `comport:` Defines the COM port to recieve on, number only. Please see [FAQ: How do I know what COM port to use?](#how-do-i-know-what-com-port-to-use)
2. `IDs:` A list that defines which application is bound to which potentiometer. Top to bottom -> left to right on your HAM device. Please note that this option is case sensitive
3. `baudrate:` Defines the baudrate (communication speed) of the software, this **MUST** match the firmware. The default is 9600
4. `bytesize:` Default is 8
5. `parity:` N for now and Y for yes. At this point HAM does not use parity
6. `stopbits:` Default is 1

## How to build your own
### Before building
1. First make sure you have everything from the [BOM](#bom)
2. If you want to use the designed case you will need a 3D printer. Otherwise you're free to make your own out of what ever material you like! You can get the 3D print  files on [Printables](https://www.printables.com/model/342910-ham-low-profile-front-controls-case) or download them straight from the repo [here](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Models) 
3. You will need to have a working version of the [Arduino IDE](https://www.arduino.cc/en/software) this is required to flash the firmware. 
