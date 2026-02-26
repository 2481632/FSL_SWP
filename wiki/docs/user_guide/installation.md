# Installation

This guide walks you through installing AR Flood App on your Android device.

## Prerequisites

### Device Requirements

- **Android Version**: 11.0 (API Level 30) or higher
- **ARCore Support**: Your device must support ARCore
- **Storage**: At least 150 MB free space
- **RAM**: Minimum 2 GB recommended

### Check ARCore Compatibility

Visit [Google's ARCore Supported Devices](https://developers.google.com/ar/devices) to verify your device is supported.

## Installation Methods

### Method 1: APK Installation (Recommended)

1. **Download the APK**
```
   AR_Flood.apk from the repository 
```

2. **Enable Unknown Sources**
    - Go to Settings → Security
    - Enable "Install unknown apps" for your browser/file manager

3. **Install the APK**
    - Locate the downloaded APK file
    - Tap to install
    - Follow the on-screen prompts

4. **Launch the App**
    - Find "AR Flood" in your app drawer
    - Tap to open

### Method 2: Build from Source

For developers who want to build from source:
download the folder unityProjekt/water_Test

See [Developer Guide - Setup](../developer_guide/setup.md) for complete instructions.

## Post-Installation

### Grant Permissions

On first launch, grant these permissions:

1. **Camera** 
    - Required for AR visualization
    - Tap "Allow" when prompted

2. **Location** 
    - Required for GPS positioning
    - Choose "While using the app"

3. **Internet** 
    - Required for fetching water level data
    - Automatically granted

### Verify Installation

1. Open the app
2. You should see the AR camera view
3. Grant all permissions
4. Look for "Loading water level..." in the UI

If you see the AR view, installation was successful! 

## Troubleshooting Installation

### "App not installed" Error

**Possible causes:**

- Insufficient storage space
- Corrupted APK file
- Incompatible Android version

**Solutions:**

1. Free up storage space (need ~150 MB)
2. Re-download the APK
3. Verify your Android version is 11.0+

### "App not compatible with this device"

**Possible causes:**

- Device doesn't support ARCore
- Android version too old

**Solutions:**

1. Check [ARCore compatibility list](https://developers.google.com/ar/devices)
2. Update Android to latest version
3. Try on a different device

### ARCore Not Installed

If prompted to install ARCore:

1. Tap "Install" when prompted
2. You'll be redirected to Google Play Store
3. Install "Google Play Services for AR"
4. Return to the app and try again

### Permission Issues

If permissions aren't working:

1. Go to Settings → Apps → AR Flood Viz
2. Tap "Permissions"
3. Manually enable Camera and Location
4. Restart the app


## Next Steps

- Read [Getting Started](getting_started.md) to learn how to use the app
- Check [Compatibility](compatibility.md) for detailed device requirements
- Visit [How to Use](how_to_use.md) for feature documentation