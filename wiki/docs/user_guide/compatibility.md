# Compatibility

Detailed information about device and system requirements for AR Flood Visualization.

## Android Requirements

### Minimum Requirements

| Requirement | Specification |
|------------|---------------|
| **OS Version** | Android 11.0 (API Level 30) |
| **ARCore** | Required (installed automatically) |
| **RAM** | 2 GB minimum, 4 GB recommended |
| **Storage** | 150 MB free space |
| **Camera** | Rear-facing camera required |
| **GPS** | GPS/GLONASS/Galileo support |
| **Network** | WiFi or mobile data (3G minimum, 4G/5G recommended) |

### Recommended Requirements

For optimal performance:

| Component | Recommended Spec |
|-----------|-----------------|
| **OS Version** | Android 12.0 or higher |
| **Processor** | Snapdragon 600 series or equivalent |
| **RAM** | 4 GB or more |
| **GPU** | Adreno 500+ or Mali-G71+ |
| **Display** | 1080p or higher |
| **Network** | 4G LTE or 5G |

## ARCore Compatibility

### What is ARCore?

ARCore is Google's platform for building augmented reality experiences. It's required for this app to work.

### Supported Devices

Check if your device supports ARCore:

1. Visit [Google's ARCore Supported Devices](https://developers.google.com/ar/devices)
2. Search for your device model
3. Verify it's listed as supported


## Regional Limitations

### GPS Coverage

- **Works Worldwide**: GPS functionality available globally
- **Best Results**: Clear view of sky, outdoors

### Pegelonline API Coverage

- **Primary Coverage**: Germany 
- **Limitations**: Outside Germany, the app will use demo mode

### Elevation API Coverage

- **Open-Meteo**: Global coverage 
- **Accuracy**: Varies by region (±5-10m)

## Network Requirements

### Internet Connection

Required for:

- Fetching current water levels (Pegelonline API)
- Getting elevation data (Open-Meteo API)
- Updating gauge station information

### Offline Capabilities

Limited offline functionality:

- AR visualization works offline
- Demo mode works offline
- Live water levels require internet
- Elevation API requires internet


## Permissions Required

The app requires these permissions to function:
```
Camera (CAMERA)
- Required for AR visualization
- Used to display real-world view

Location (ACCESS_FINE_LOCATION)
- Required for GPS positioning
- Used to calculate your elevation

Internet (INTERNET)
- Required for API access
- Used to fetch water level data
```

All permissions can be reviewed and managed in:  
`Settings → Apps → AR Flood App → Permissions`


## Known Incompatibilities

### Devices WITHOUT ARCore

These devices will NOT work:

- Most devices older than 2018
- Smartphones without ARCore certification
- Tablets without AR support
- Devices with Android < 11.0

### Software Conflicts

May conflict with:

- Other AR apps running simultaneously
- Aggressive battery savers
- Custom camera apps
- Screen overlays

## Testing Your Device

### Verification Steps

1. **Install ARCore**
    - Download "Google Play Services for AR" from Play Store
    - If it installs successfully, ARCore is supported 

2. **Test GPS**
    - Open Google Maps
    - Check if location is accurate
    - GPS must work for this app 

3. **Test Camera**
    - Open camera app
    - Verify rear camera works
    - AR requires functional camera 

## Future Compatibility

### Planned Support

We're planning to work on:

- iOS version (ARKit)
- Web-based viewer (WebXR)
- Lower Android versions (Android 10)

## Next Steps

- Install the app: [Installation Guide](installation.md)
- Learn to use it: [Getting Started](getting_started.md)
- Need help? [Troubleshooting](troubleshooting.md)