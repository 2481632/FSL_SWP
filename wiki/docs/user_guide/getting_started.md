# Getting Started

Welcome to AR Flood Visualization. This guide will help you get started with using the app.

## What You'll Need

Before you begin, make sure you have:

- An Android device running Android 11.0 or higher
- ARCore support (check [ARCore supported devices](https://developers.google.com/ar/devices))
- GPS enabled on your device
- Internet connection for live data
- Camera permissions

## First Launch

1. **Install the App**  
   Follow the [Installation Guide](installation.md) to install the app on your device.

2. **Grant Permissions**  
   On first launch, you'll be asked to grant:
   - Camera access (required for AR)
   - Location access (required for GPS positioning)
   - Internet access (for fetching water level data)

3. **Choose Your Mode**  
   - **Live Mode**: Uses real data from Pegelonline API
   - **Demo Mode**: Uses simulated data for testing

## Basic Usage

### Understanding the Interface

The app consists of several key elements:

**Debug Panel** (top right):
- GPS coordinates (latitude/longitude)
- Elevation at your location
- Current water height over gauge zero
- Water height over normal null

**AR View** (center):
- Live camera feed
- Water plane showing flood level
- Adjusts in real-time based on your position

**Info Button** (top left):
- turns debug panel display on/off

**Demo Mode Button** (top left):
- enter demo mode, return from demo mode

**Floor Selector** (top left):
- Select which floor you're on (-3 to 45)
- Adjusts the water visualization accordingly

### Your First Visualization

1. **Enable AR**  
   Point your phone camera at the ground and move slowly to let ARCore detect the surface.

2. **Wait for Data**  
   The app fetches current water levels. You'll see "Loading water level..." briefly.

3. **View the Flood Level**  
   The Water Plane represents where flood water would reach at your location.

4. **Adjust Your Floor**  
   Use the floor dropdown to select your current level. The water plane adjusts accordingly.


## Understanding the Visualization

The Water plane shows:

- **Below ground level**: You're safe from flooding at this location
- **At ground level**: Water would reach your feet
- **Above ground level**: Your location would be flooded to that height

The calculation takes into account:
- Current water level from the nearest gauge station
- Gauge zero height (reference point)
- Your GPS elevation
- Your selected floor level

## Limitations
- Elevation data accuracy varies by location (±5-10m)
- Water levels are from the nearest gauge station
- This is a visualization tool, not an official warning system

## What's Next?

- Learn about [Compatibility](compatibility.md)
- Read [How to Use](how_to_use.md) for detailed features
- Check [Troubleshooting](troubleshooting.md) if you encounter issues