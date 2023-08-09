# Unity Job System
![image](https://github.com/CreatNatoy/Unity-Job-System/assets/76531899/c75b6910-1521-4e50-8f12-686924d5d253)
<p align="center">
    <img src="https://img.shields.io/badge/Engine-2021.3.11f1-blueviolet" alt="Unity Version">
    <img src="https://img.shields.io/badge/Version-0.1-blue" alt="Game Version">
    <img src="https://img.shields.io/badge/License-None-success" alt="License">
</p>

## Job system. 
The job system lets you write simple and safe multithreaded code so that your application can use all available CPU cores to execute your code. This can help improve the performance of your application.

## Used

* Job system
* Burst Compile

## Description

In this project, we will compare operations performed with the Job system and without the Job system. We will create two arrays of objects that will perform addition mathematical operations in a loop.

1) JobSystemUnits Array with Job system.
2) UsualUnits Array without Job system.
   
And we will compare the FPS.

![image](https://github.com/CreatNatoy/Unity-Job-System/assets/76531899/3ef830ec-5024-408f-b1de-467af9b04a97)

Turn on one of the objects and compare FPS

![image](https://github.com/CreatNatoy/Unity-Job-System/assets/76531899/48e12996-dad0-43e3-a423-76b739c53e57)

Here are two mathematical operations: one using the Job system and the other without the Job system.

FPS without the Job system (34 fps)

![image](https://github.com/CreatNatoy/Unity-Job-System/assets/76531899/310266f7-533e-406f-b40d-8b36a9f4a9ad)

FPS with the Job system (173 fps)

![image](https://github.com/CreatNatoy/Unity-Job-System/assets/76531899/b964d9aa-0b80-43e7-9987-328148ee64e1)
