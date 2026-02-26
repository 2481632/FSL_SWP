# How to Use

A comprehensive guide to all features and functionality of AR Flood App.

## Interface Overview

### Main Screen Elements

#### 1. Debug Panel (Top Right)

Displays real-time technical information:
```
GPS
Lat:  52.5200
Lon:  13.4050
Elev: 34 m

WASSER
Höhe Gewässer über Pegelnull: 245.0 cm
Pegelnullstand: 32.15 m
Höhe über NN: 34.60 m

KAMERA
Kamerahöhe: 1.5 m
```

**What it means:**

- **Lat/Lon**: Your GPS coordinates
- **Elev**: Your elevation above sea level
- **Höhe Gewässer**: Water height above gauge zero
- **Pegelnullstand**: The gauge's reference point
- **Höhe über NN**: Water height above normal null (sea level)
- **Kamerahöhe**: Height of your camera above ground

#### 2. AR Camera View (Center)

The main visualization area showing:

- Live camera feed from your device
- Water plane at calculated flood level
- Real-time positioning as you move

#### 3. Flood Height Display

Shows the calculated flood height at your position:
```
Fluthöhe: 2.5 m
```

- Positive value: You would be flooded
- Negative value: You are above flood level

#### 4. Floor Selector (Top Left)

Dropdown menu to select your floor level:

- Range: B3 (basement 3) to Floor 45
- Each floor = 3 meters height
- Ground floor = 0 meters

#### 5. Demo Mode Button (Top Left)

Button to switch into the Demo Mode.

#### 6. Info Button (Top Left)

Button to turn the Debug Panel Display on/off.

#### 7. Demo Scene

When in the demo mode:

- Live camera feed from your device 
- Water panel displayed
- Water panel controllable with slider 

## Step-by-Step Usage

### Starting the App

1. **Launch** the app from your home screen
2. **Point camera** at the ground
3. **Move slowly** to help ARCore detect surfaces
4. **Wait** for data to load (3-5 seconds)

### Selecting Your Mode

#### Live Mode (Default)

Uses real-time data from Pegelonline API:

- Automatic station selection based on GPS
- Updates every 5 seconds
- Requires internet connection

#### Demo Mode

Uses simulated flood data:

- Useful for testing without real flood conditions
- Works offline

### Adjusting Floor Level

1. Tap the **Floor dropdown** at the bottom
2. Select your current floor:
    - `Ground` for ground level
    - `Floor: 1`, `Floor: 2`, etc. for upper floors
    - `Floor: B1`, `Floor: B2`, etc. for basements
3. Water plane adjusts automatically


### Moving Around

As you walk:

- GPS updates your position
- Elevation changes affect the calculation
- Water plane repositions in real-time

**Best practices:**

- Walk slowly for stable AR tracking
- Stay outdoors for best GPS signal
- Avoid rapid movements

### Interpreting Flood Height

The "Fluthöhe" value shows:
```
Fluthöhe: 2.3 m  → You're 2.3m below water level
Fluthöhe: 0.5 m  → Water at low level
Fluthöhe: -1.2 m → You're 1.2m above water (safe)
```

## Advanced Features

### Understanding Data Sources

The app combines multiple data sources:

1. **Pegelonline API**
    - Current water levels from official gauges
    - Updates every few minutes
    - Covers major rivers in Germany

2. **Open-Meteo Elevation API**
    - Provides elevation at your GPS position
    - Accuracy: ±5-10 meters
    - Global coverage

3. **Device GPS**
    - Your latitude/longitude
    - Accuracy: ±5-20 meters depending on conditions

### Calculation Method

The water height at your position is calculated as:
```
Water Height (your position) = 
    Water Height (gauge) 
    + Gauge Zero Height
    - Your Elevation
    - Your Floor Offset
    - Camera Height
```

### Dealing with Inaccuracies

Sources of error:

- GPS accuracy (±5-20m horizontally)
- Elevation data accuracy (±5-10m vertically)
- Distance from gauge station
- Terrain variations

Important:

    This app is for visualization only. Always rely on official flood warnings and evacuation orders from authorities.


## Limitations

Be aware of these limitations:

- **Data Delay**: Water levels update every 5 seconds
- **Coverage**: Only works near Pegelonline stations
- **Elevation**: Accuracy varies by location
- **AR Tracking**: Requires textured surfaces
- **Battery**: AR uses significant battery power

## Troubleshooting

Common issues and solutions:

| Problem | Solution |
|---------|----------|
| Water plane not visible | Check if you're very far from water level |
| GPS coordinates not updating | Enable location services, wait outdoors |
| "Loading water level..." stuck | Check internet connection |
| AR tracking lost | Point at textured ground, move slowly |
| Battery draining fast | Normal for AR apps, use power saving mode |

See [Troubleshooting Guide](troubleshooting.md) for more help.

## Next Steps

- Learn about [Compatibility](compatibility.md)
- Check [Troubleshooting](troubleshooting.md) for issues
- Explore [Developer Guide](../developer_guide/overview.md) to contribute