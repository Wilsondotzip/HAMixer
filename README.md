# HAM - *HardwareApplicationMixer*
HAM is a hardware application mixer for changing the volume of different  windows apps on the fly. No more digging through menus. Easily adjust the volume of your music, voice chat or game to be just how you like it.  This project is still in active development you can see all the features we plan to add [here](#what's-to-come) and if you have any feedback or requests don't hesitate to log an issue.
# Warning: You're on the experimental version, documentation will not be up to date!
![Image1](https://user-images.githubusercontent.com/58171274/208287616-4ac56eff-1d69-4b42-90ca-15974aa2479a.jpg)

# Contents:
### [Getting Started](#getting-started)
 - [How things work](#how-things-work)
 - [Requirements](#requirements)
 - [Using config files](#using-config-files)
 - [How to build your own](#how-to-build-your-own)
    - [BOM](#bom)
### [Features ](#features)
 - [Whats here](#features)
 - [Whats to come](#whats-to-come)
### [FAQ ](#faq)
 - [How do I know what COM port to use?](#how-do-i-know-what-com-port-to-use?)


# Getting Started:

## How things work
A Python script runs in the background to turn the Arduino's serial inputs into volume changes. The Arduino reads each potentiometer as a separate analogue input, this information (once mapped between [0,100]) is then sent to your computer over a COM port. The python program runs to receive the information and convert it to meaningful volume commands!  

![Image2](https://user-images.githubusercontent.com/58171274/208288002-e05144c8-9d7c-4ace-b45a-9c51406f2135.jpg)

## Requirements
Currently only **Windows** is tested and supported to work. Adding Linux support is something high on our priority list.
If you have windows you're all set nothing else is needed! Go grab the [compiled exe](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Software) and run it inside its own folder with the config file. 

Alternatively  you can use the [source code](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Software/Source) instead. 

## Using config files
Configuration files are mainly used to bind applications to potentiometers and define the COM port your HAM is connected to. A config file is needed in order to run the HAM software, so make sure your config.yaml file is in the same directory. Config files are written using YAML, here's an example config file.
```YAML
comport: COM4
baudrate: 9600
bytesize: 8
parity: N
stopbits: 1

Mappings:
    ID1:
        Applications: Discord.exe;plex.exe 
    ID2:
        Applications: 

```
You can add as many IDs as you want In any order. Just make sure to seperate grouped applications by using a `;` 
1. `comport:` Defines the COM port to receive  on, number only. Please see [FAQ: How do I know what COM port to use?](#how-do-i-know-what-com-port-to-use)
2. `IDs:` A list that defines which application is bound to which potentiometer. Top to bottom -> left to right on your HAM device. Please note that this option is case sensitive
3. `baudrate:` Defines the baudrate (communication speed) of the software, this **MUST** match the firmware. The default is 9600
4. `bytesize:` Default is 8
5. `parity:` N is for no and Y is for yes. At this point HAM does not use parity
6. `stopbits:` Default is 1

## How to build your own
### Before building
1. First make sure you have everything from the [BOM](#bom)
2. If you want to use the designed case you will need a 3D printer. Otherwise you're free to make your own out of whatever  material you like! You can get the 3D print  files on [Printables](https://www![HAM-Controller-Breakdown](https://user-images.githubusercontent.com/58171274/214249625-39367b9b-4ed1-4e00-ba27-8ec25c6b40d4.png)
.printables.com/model/342910-ham-low-profile-front-controls-case) or download them straight from the repo [here](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Models) 
3. You will need to have a working version of the [Arduino IDE](https://www.arduino.cc/en/software) this is required to flash the firmware. 
### Step 1: 3D Printing
Slice and print the 3D case files. You will need one of each file however you do not need to print case.stl that is not made for 3D printing. The recommended  print settings are as follows:
- No Supports
- 20% infill
- PLA 
- Use a [skirt](https://www.simplify3d.com/resources/articles/rafts-skirts-and-brims/) for best first layer

### Step 2: Front Panel Assembly 
Push all four of your potentiometers into the front panel and secure them with their accompanying  nuts. Now turn each potentiometer to its anticlockwise end-stop and push on their knobs. Make sure to align  each knob so its indicator line is pointing at 7 o'clock. It may take a bit of trial and error to match them up but when done correctly each indicator line should point at 7 o'clock when turned to the left and 5 o'clock when turned to the right.

### Step 3: Front Panel Soldering
This is the hardest part, but its not that complicated just follow the wiring guide! **Note:** It is important to know that A0 needs to be slightly longer than A1, A1 needs to be slightly longer than A2, and A2 slightly longer than A3. It is recommended that you roughly measure out each wirelength beforehand by loosely running them from their point on the front panel, to the desired input on the Arduino before soldering.

![Connection Diagram](https://user-images.githubusercontent.com/58171274/208300714-56217444-0cdb-454c-9468-23e939f96199.png)

 A0, A1, A2, A3, 5V and GND will all be connected to the Arduino later on. I recommend  soldering the analogue inputs to their own strip of header, as well as the 5V and GND wires. This makes it much easier to connect to the Arduino. If not, make sure to use single core wire, however you may run into reliability issues if the connection is loose. Use heat shrink if you want to keep things well insulated. Here is a example of using header. 
 
 ![UsingHeader](https://user-images.githubusercontent.com/58171274/208301547-19b94759-febe-4c88-a2aa-d67161c7ca49.png)
 
 ### Step 4: Mounting and assembly
Use M3 machine screws to secure the Arduino UNO or compatible board to the [bottom case pannel](https://github.com/Wilsondotzip/HardwareApplicationMixer/blob/main/Models/CaseBottom.stl). Then attach the front panel using two more screws and plug in the input pins and 5V + GND wires. With another 2 screws you can attach the [back panel](https://github.com/Wilsondotzip/HardwareApplicationMixer/blob/main/Models/CaseBackPanel.stl), making sure to align  the USB-B connector. Once that's on the [top panel](https://github.com/Wilsondotzip/HardwareApplicationMixer/blob/main/Models/CaseTop.stl) can be slid on vertically, just make sure to align the screw holes and add the remaining 4 screws. That's it for hardware assembly!

 ### Step 5: Flashing firmware
 If you haven’t  already, clone the repository and open the [firmware](https://github.com/Wilsondotzip/HardwareApplicationMixer/tree/main/Firmware/main) using the [Arduino IDE](https://www.arduino.cc/en/software). Plug in your Arduino (now inside the HAM case) and [upload the project firmware](https://support.arduino.cc/hc/en-us/articles/4733418441116-Upload-a-sketch-in-Arduino-IDE). To validate that things are working open the serial monitor. You should see numbers which increase when you turn a knob clockwise and decrease when you turn a knob anticlockwise. 
 Depending on the knob you turn it will have a different `ID` AKA the number after the `@` symbol will be different. The order of `IDs` from left to right should be 1,2,3,4. If every knob has a number but the numbers are out of order you have miss wired the analogue inputs. 
 
An example of a possible serial monitor output:
```
1@1
4@1
5@1
7@1
10@1
25@3
20@3
19&3
```
Before leaving the Arduino IDE take note of what COM port your device is using. This will be used when setting up the config file.

### Step 6: Running the software
The hard part is done! HAM offers two software varients, a headless and a GUI version both for Windows. Download the package you want from the releases page or the repo's software folder. Before using the headless version please read [Using Config Files](#using-config-files). Make sure the config file, icon and HAM-Headless.exe are in the same folder then open `HAM-WindowsGUI.exe`.
Here's a quick rundown on how to use the software.

![WindowsGUI](https://github.com/Wilsondotzip/HardwareApplicationMixer/blob/experimental/Images/HAM-Controller-Breakdown.png)

To verify it is indeed working go to `Settings > System > Sound > Volume mixer` and watch the application volumes change as you turn the knobs provided you have setup your config file.

## BOM
1. Arduino Uno or compatible board x1 https://store.arduino.cc/products/arduino-uno-rev3
2. Potentiometers x4 (can be any value) https://www.aliexpress.com/item/1005003390403815.html
3. Potentiometer Knobs x4 https://www.aliexpress.com/item/4001081531606.html
4. USB 2.0 Cable A/B x1 https://www.aliexpress.com/item/1005003972190826.html
5. Wire, multicore or solid core
6. Male header x6 pins (just buy a bunch lol) https://www.aliexpress.com/item/32758380907.html
7. M3 machine screws roughly 6mm in length will do x12 https://www.aliexpress.com/item/4000384925292.html
8. Optional threaded inserts x12 https://www.aliexpress.com/item/1005003314830904.html 
9. Optional heatshrink diameter depends on the wire you use, https://www.aliexpress.com/item/4000272238274.html

# Features
- Map an applications volume to a specific control knob
- Application grouping, to have multiple applications controlled by one knob
- Full Windows GUI, for easy setup and application mapping!
- When minimized, software which runs quietly in the background as a tray icon
- Easy to use config files
- A headless software varient
- Full Windows support

## What’s to come...
This project is still in active development, so here are some of the features we plan to add in the future.
- Linux support. Its getting there... 
- More cases! I mean more! All of the cases, every case. Front controls top controls you name it!
- A pretty UI that has easy to customize colours.
- Verified firmware support for other microcontrollers, not everyone has an Arduino Uno. How about an Arduino Micro, or ESP?
- Not yet sure how to do this one but somewhere down the line we would like to add control over hardware devices like microphones and speakers.
- Buttons for possible functions like muting and config switching. 
- In the long run It would be great to have a custom PCB, to make easy to build kits possible.
- Have an idea? Let us know. 

# FAQ
### Q: How do I know what COM port to use?
You can find the COM port by going into device manager and looking under `Ports (COM & LPT)`

![image](https://user-images.githubusercontent.com/58171274/208324820-ebd665f9-d3c1-421a-b480-66e81de254b6.png)
### Q: Does the potentiometers value make a difference?
Nope! You can use whatever value potentiometers you want. 

### Q: Can I use an ESP or a (insert other microcontroller here)?
Maybe! Although the project isn’t verified to work on said microcontroller, there’s a good chance it will. If the microcontroller is compatible with the Arduino IDE, there's a good chance everything will work perfectly fine. However, you may also need to change the names of the analogue pins used in the firmware if your microcontroller has a different naming scheme. Test the firmware before going any further with a unverified controller. If the serial output is to the same standard as shown, there should be no issues.
