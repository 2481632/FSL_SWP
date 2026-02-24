# Development Environment Setup

Information about our setup used for development of the App.

## Software 

Software and Technologies needed for development:
* **Game Engine**: Unity 2021.3 LTS
* **AR Framework**: Unity AR Foundation 5.x
* **IDE**: Visual Studio Code or other code editor 

## Unity Setup

The precise settings can be found in the config-files in the project directory. 

Project Settings:
* ProjectSettings/Player select Android 

Editor Build Settings:
* File/Build Settings/Android 
* if Android already active, you can build the app
* if Android not active click "switch platform"

## Assets
From the Unity Asset Store we used the URP Stylized Water Shader - Proto Series from BitGem.
If it isn't available for free anymore when you are developing, you can switch to any other Water Shader from the Unity Asset Store that is URP compatible. Then you have to adjust ARWater Plane, remove the current Material that is in there an change to your new one. 