# Error Handling

Common errors we encountered during development and how to resolve them.

## Development Errors

### Unity Script Errors

**Error: "MonoBehaviour cannot be used as standalone"**

```
CS0246: The type or namespace name 'MonoBehaviour' could not be found
```

**Cause:** Script doesn't inherit from MonoBehaviour

**Solution:**
```csharp
// Wrong
public class MyScript {
    void Start() { }
}

// Correct
public class MyScript : MonoBehaviour {
    void Start() { }
}
```

**All Unity scripts that interact with GameObjects must inherit from MonoBehaviour.**

---

**Error: "Public field not set in Inspector"**

```
NullReferenceException: Object reference not set to an instance of an object
```

**Cause:** Public fields (like API URLs, GameObjects) not assigned in Inspector

**Solution:**

1. Select GameObject in Hierarchy
2. Check Inspector panel
3. Find your script component
4. Assign all public fields:
   - `apiUrl` → Enter URL string
   - `displayText` → Drag TextMeshProUGUI object
   - `waterPlane` → Drag WaterPlane GameObject

---

## Runtime Errors

### GPS / Location Errors

**Error: "GPS not working / coordinates always 0.0"**

Location Services Disabled:
```
Settings → Location → On
Settings → Apps → AR Flood App → Permissions → Location → Allow
```
---

### AR / Camera Errors

**Error: "Camera shows black screen"**

**Causes & Solutions:**

**1. Camera Permission Denied**
```
Settings → Apps → AR Flood Viz → Permissions → Camera → Allow
```

**2. ARCore Not Installed**
```
Install "Google Play Services for AR" from Play Store
```

**3. Device Not ARCore Compatible**
- Check: https://developers.google.com/ar/devices
- Try different device

---


## Testing Errors

### Device Testing Issues

**Error: "Device not detected by Unity"**

**Solutions:**

1. **Enable USB Debugging:**
   ```
   Settings → About Phone → Tap Build Number 7 times
   Settings → Developer Options → USB Debugging → On
   ```

2. **Check ADB:**
   ```bash
   adb devices
   # Should show your device
   ```
---


## Quick Reference

### Error Code Lookup

| Error Type | Check | Fix |
|------------|-------|-----|
| NullReferenceException | Inspector assignments | Assign public fields |
| JSON parse error | API response format | Validate JSON structure |
| GPS not working | Location settings | Enable GPS + permissions |
| Black camera | Camera permission | Grant permission |
| Build failed | Gradle/SDK | Update build tools |
| Device not detected | USB debugging | Enable developer options |
