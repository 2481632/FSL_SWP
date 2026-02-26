# Setup

Complete guide to setting up your development environment for AR Flood Visualization.

## Required Software

### Core Development Tools

**1. Unity Hub & Unity Editor**

```
Unity Hub: https://unity.com/download
Unity Version: 2021.3 LTS or newer
```

**Required Unity Modules:**
- Android Build Support
- Android SDK & NDK Tools
- OpenJDK (included with Unity)


**2. Code Editor**

Visual Studio or other 


## Project Setup

* Download the directory unityProject/water_Test and open in Unity


### Verify Android Build Support

1. File → Build Settings
2. Check if "Android" is listed under Platform
3. If not listed: Unity module not installed, go back to Unity Hub
4. If listed but not active: Click "Switch Platform" 


### Verify AR Foundation

**Check Package Manager:**

1. Window → Package Manager
2. Select "Unity Registry" (top left)
3. Search for "AR Foundation"
4. Should show version 5.x (installed)
5. Also check "ARCore XR Plugin" (installed)

**If Not Installed:**

Install under package manager.


## Assets & Resources

### Unity Asset Store Assets

**URP Stylized Water Shader - Proto Series by BitGem**

**Original Asset (used in development):**
```
Asset: URP Stylized Water Shader - Proto Series
Developer: BitGem
Type: Water shader for URP
Status: May not be free anymore
```

**Alternative Water Shaders (if original unavailable or not free anymore):**

Any water shader from the Unity Asset Store that supports URP.
You could also build your own shader. 

### Replacing Water Material

If you need to use a different water shader:

**Step 1: Import New Shader**
- Download from Asset Store
- Import into project

**Step 2: Create New Material**
```
Project Window → Right Click → Create → Material
```

**Step 3: Assign Shader**
```
Select new material
Inspector → Shader dropdown → Select your water shader
Configure shader properties (color, transparency, etc.)
```

**Step 4: Update Water Plane**
```
Hierarchy → ARWater GameObject
Inspector → Mesh Renderer → Materials
Replace old material with new material
```

## Testing Setup

### Device Setup for Testing

**Enable Developer Options on Android Device**

```
Settings → About Phone
Tap "Build Number" 7 times
"Developer options" now available
```

**Enable USB Debugging**

```
Settings → System → Developer Options
USB Debugging → Enable
```

**Connect Device to Computer**

```
Connect via USB cable
On device: Allow USB debugging
On computer: Verify device detected
```

### Test Build

**Quick Test Build:**

```
File → Build Settings
Ensure device connected
Click "Build and Run"
Choose filename: test.apk
Save anywhere (Desktop, Downloads)
Unity builds and installs automatically
App launches on device
```

**If Build Fails:**
- Check device connected (adb devices)
- Check USB debugging enabled
- Try "Refresh" in Build Settings
- Check Console for errors


## Next Steps

Once your environment is set up:

1. **Read the Architecture Guide**  
   [Architecture Documentation](architecture.md)

2. **Understand the Design Decisions**  
   [Design Decisions](design_decisions.md)

3. **Building Guide**  
   [Building Guide](building.md)

