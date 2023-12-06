

<p align="center">
  <img src="https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/847c0696-b07c-483e-ae4a-0032434afe11"/>
</p>


# How to Build and Animate Gauges in C# WinForms Using LiveCharts
#### This is a simple way to build Angular Gauges for C# WinForms when the drag-and-drop feature is not available in the designer.


## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Prerequesites](#prerequesites)
* [Setup](#setup)
* [Manual Setup Build](#manual-build)
* [Screenshots](#screenshots)

![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/1bda43b9-657a-46b7-907b-f0d3fa60d277)

## General Info
### Why I made this simple build solution for LiveCharts Angular Gauges.
So, TL;DR. I decided to add telemetry gauges to my remote flight controller assignment for year 2 comp sci, but I could not drag-and-drop the guage from the designer toolbox as it was not in the list. Even after trying many different fixes, I eventually realised that I would have to manually build the gauge. The only problem... there was no documentation on how to create this specific gauge. But thanks to my wonderful mentor [A.J](https://github.com/TiredAJ), we were able to figure out the syntax and build a handsome-looking gauge. I then went on to build six guages for my assessment.

## Prerequesites
The gauges are not difficult to build, however, Event-Driven programing is something that will need to be learned or understood to be able to make them work. You will also need to be able to follow the nuiget pacakge installation tutorial below. Othewise the barrier of entry into LiveChart package is very low and novice-friendly. See here for [LiveCharts Installation](#setup)
## Technologies
This tutorial was created with:
* Visual Sutdio
* C#
* WinForms .Net(framework)
* LiveCharts 2 (nuiget package installation)
* Threads and Delegates

## Setup
To ensure the Angular Gauges work on your Visual Studio, you will need to install the nuiget package for Live Charts.

1. To find your package manager window, right click on the name of your solution in the solution explorer. You can see in the image below that I have highlighted the correct selection.
![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/5310966c-ad90-4dd9-903e-23ee8d70cd97)

2. The package manager screen will open in the "Installed" tab.
3. You will need to change it to the "Browse" tab and search for 'LiveCharts'. The search bar is under the "Browse" tab. 
![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/183b473c-49a4-470b-a0dd-dd9215d23ebf)

4. Ensure you are installing the correct version of LiveCharts for your WinForm - for example a .Net framework project uses the WinForm download.
5. The "install" button is located on the right side of the packages window
![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/933743a5-6b7d-469f-9d0a-341cc090bc36)
6. This single selection will download all the dependencies.
![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/285a8bd0-8764-43fd-b701-c5bb96874240)
7. Ignore this webpage. just close it.
![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/0d074965-7542-4109-bf2e-2ae1bbb710ae)

## Manual Build
It is important to understand that most programmers are going to find a drag-and-drop element in their design toolbox. If it is there, use it. If you are unable to get the designer to load the LiveChart elements in the toolbox, we can use the manual build workaround.

For ease of learning, all build syntax has been written in the form1 class so any beginner WinFormers can find and replicate this workaround without delving into the Designer.cs file. 
From herem you can check out the code in the repository on do a pull request. If you would like to view the code right here in GitHub, [click here.](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/blob/main/SimpleAngularGauge/Form1.cs)

## Screenshots
Under Construction...
![image](https://github.com/WillowSaysWhat/Simple-LiveCharts-Anguar-Gauge/assets/126318401/623498c1-959a-4636-b0d0-4a2ad309ca64)
