# Troubleshooting

Common issues and their solutions for AR Flood App.

## Installation Issues

### App Won't Install

**Symptoms**: "App not installed" error message

**Possible Causes:**

- Insufficient storage space
- Corrupted APK file
- Android version incompatibility

**Solutions:**

1. **Check Storage**
```
   Settings → Storage → Check available space
   Need: 150 MB minimum
```

2. **Re-download APK**
    - Delete the current APK
    - Download again from official source
    - Verify file size matches (should be ~120 MB)

3. **Verify Android Version**
```
   Settings → About Phone → Android Version
   Required: 11.0 or higher
```

### "App Not Compatible" Error

**Symptoms**: Play Store or APK says incompatible

**Solutions:**

1. **Check ARCore Support**
    - Visit [ARCore Devices](https://developers.google.com/ar/devices)
    - Your device must be on this list

2. **Update Android**
```
   Settings → System → System Update
   Install any available updates
```

3. **Try Different Device**
    - Not all devices support ARCore
    - Consider testing on a compatible device

### ARCore Installation Fails

**Symptoms**: Prompted to install ARCore, but installation fails

**Solutions:**

1. **Update Play Store**
    - Open Play Store → Menu → Settings
    - Update Play Store to latest version

2. **Clear Play Store Cache**
```
   Settings → Apps → Google Play Store
   → Storage → Clear Cache
```

3. **Manual ARCore Install**
    - Search "Google Play Services for AR" in Play Store
    - Install directly

## Runtime Issues

### App Crashes on Launch

**Symptoms**: App opens then immediately closes

**Solutions:**

1. **Clear App Data**
```
   Settings → Apps → AR Flood Viz
   → Storage → Clear Data
   Restart app
```

2. **Reinstall App**
    - Uninstall completely
    - Restart device
    - Reinstall from APK

3. **Check Permissions**
```
   Settings → Apps → AR Flood Viz → Permissions
   Ensure Camera and Location are enabled
```

### Camera Not Working

**Symptoms**: Black screen or "Camera permission denied"

**Solutions:**

1. **Grant Camera Permission**
```
   Settings → Apps → AR Flood Viz → Permissions
   → Camera → Allow
```

2. **Check Camera in Other Apps**
    - Open default camera app
    - If camera doesn't work there, it's a device issue

3. **Close Other Camera Apps**
    - Close all apps using the camera
    - Restart AR Flood Viz

4. **Restart Device**
    - Complete device restart often fixes camera issues

### GPS Not Working

**Symptoms**: "Lat: 0.0, Lon: 0.0" or coordinates not updating

**Solutions:**

1. **Enable Location Services**
```
   Settings → Location → On
   Mode: High accuracy
```

2. **Grant Location Permission**
```
   Settings → Apps → AR Flood Viz → Permissions
   → Location → Allow all the time (or While using app)
```

3. **Go Outdoors**
    - GPS requires clear view of sky
    - Move away from tall buildings
    - Wait 30-60 seconds for GPS lock

4. **Restart GPS**
    - Toggle Airplane mode on/off
    - Or restart device

### "Loading Water Level..." Stuck

**Symptoms**: Loading message never disappears

**Solutions:**

1. **Check Internet Connection**
    - Open a web browser
    - Verify you can load websites
    - Try switching WiFi/mobile data

2. **Check API Status**
    - Pegelonline API may be down
    - Try again in 5 minutes

3. **Use Demo Mode**
    - Switch to demo mode in settings
    - This works without internet

4. **Check Location**
    - App only works near Pegelonline stations (Germany)
    - If outside coverage area, use demo mode

### AR Tracking Lost

**Symptoms**: "Tracking lost" message or water plane disappears

**Solutions:**

1. **Point at Textured Ground**
    - AR needs visual features to track
    - Avoid blank walls or uniform surfaces
    - Point at ground with texture/patterns

2. **Improve Lighting**
    - Use in well-lit areas
    - Avoid very dark or very bright conditions
    - Daylight works best

3. **Move Slowly**
    - Rapid movements confuse AR
    - Slow, steady movements work best

### Water Plane Not Visible

**Symptoms**: Can't see the Water plane

**Possible Causes:**

1. **You're Far from Water Level**
    - If flood level is below you, plane won't be visible
    - Check "Fluthöhe" value

2. **Water Level Below Ground**
    - In demo mode with low values
    - Try increasing simulated water level

3. **Rendering Issue**
    - Restart app
    - Clear cache

**Solutions:**

1. **Check Flood Height Display**
```
   If "Fluthöhe: -45.0 m"
   → Water is 45m below you (not visible)
```

2. **Adjust Floor Level**
    - Lower your floor setting
    - Try "Floor: B3" (basement) to raise water plane

3. **Use Demo Mode**
    - Set high water level
    - Verify plane is visible

## Data Issues

### Incorrect Water Levels

**Symptoms**: Water level seems wrong for your area

**Possible Causes:**

- Data from distant gauge station
- Elevation data inaccuracy
- GPS positioning error

**Solutions:**

1. **Check Distance to Station**
    - Pegelonline stations are spaced far apart
    - Data may be from 10-50km away

2. **Verify GPS Accuracy**
    - Wait for GPS to stabilize (30-60 seconds)
    - Check GPS coordinates in debug panel

3. **Compare with Official Data**
    - Visit [hochwasserzentralen.de](https://www.hochwasserzentralen.de)
    - Compare with nearest station

### Elevation Data Wrong

**Symptoms**: "Elev: X m" seems incorrect

**Known Issues:**

- Elevation API accuracy: ±5-10 meters
- DEM (Digital Elevation Model) resolution varies

**Solutions:**

1. **Accept Margin of Error**
    - ±10m is normal for elevation data
    - App is for visualization, not precision measurements

2. **Verify with Other Sources**
    - Google Earth
    - Topographic maps

3. **Report Persistent Issues**
    - If consistently wrong (>20m error)
    - Report to development team

### No Internet Connection

**Symptoms**: Cannot fetch live data

**Solutions:**

1. **Check Network**
```
   Settings → Network → Verify connection
   Test with web browser
```

2. **Switch Networks**
    - Try WiFi instead of mobile data (or vice versa)
    - Move to area with better signal

3. **Use Demo Mode**
    - Demo mode works offline
    - Toggle in settings menu

## Performance Issues

### App is Laggy

**Symptoms**: Slow, choppy AR visualization

**Solutions:**

1. **Close Background Apps**
```
   Recent Apps → Close all
   Keep only AR Flood App open
```

2. **Reduce Graphics**
    - Lower screen brightness
    - Close resource-heavy apps

3. **Restart Device**
    - Frees up RAM
    - Clears system cache

### Battery Draining Fast

**Symptoms**: Battery drops rapidly during use

**Expected Behavior:**

- AR apps use 20-30% battery per hour
- This is normal for AR technology

**Mitigation:**

1. **Use Power Saving**
    - Enable battery saver mode
    - Reduce screen brightness

2. **Limit Session Length**
    - Use app in 10-15 minute sessions
    - Take breaks

3. **Charge Device**
    - Keep device charged above 50%
    - Use portable charger if needed


## Error Messages

### "Camera Permission Denied"

**Solution:**
```
Settings → Apps → AR Flood Viz → Permissions
→ Camera → Allow
Restart app
```

### "Location Permission Denied"

**Solution:**
```
Settings → Apps → AR Flood Viz → Permissions
→ Location → Allow (While using app)
Restart app
```

### "ARCore Not Installed"

**Solution:**

1. Tap "Install" when prompted
2. Install "Google Play Services for AR"
3. Return to app

### "No Internet Connection"

**Solution:**

1. Check WiFi/mobile data is on
2. Test internet in browser
3. Restart router/device
4. Use demo mode as fallback

### "Invalid API Data"

**Solution:**

1. API may be temporarily down
2. Wait 5 minutes and try again
3. Use demo mode temporarily
4. Report if persists >1 hour

### "GPS Signal Lost"

**Solution:**

1. Move outdoors
2. Wait for GPS to reacquire (30-60s)
3. Check location services enabled
4. Restart device

## Still Having Issues?

If none of these solutions work:

1. **Check System Requirements**
    - Review [Compatibility Guide](compatibility.md)
    - Ensure device meets all requirements

2. **Report a Bug**
    - Document the issue
    - Include device model and Android version
    - Note steps to reproduce
    - Submit to GitHub issues


## Next Steps

- Return to [How to Use](how_to_use.md)
- Check [Compatibility](compatibility.md)
- Read [Developer Guide](../index.md) to contribute