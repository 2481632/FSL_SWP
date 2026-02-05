# Developer Guide Overview

Welcome to the AR Flood Visualization developer documentation. This guide is for developers who want to contribute to, extend, or understand the technical implementation of this project.

This developer guide covers:

- **Architecture**: How the system is structured
- **Setup**: Getting the development environment ready
- **Building**: Compiling and deploying the app
- **APIs**: Integration with external services
- **Design Decisions**: Why we made certain technical choices
- **Contributing**: How to contribute to the project

## Quick Start for Developers

```bash
# Clone the repository
git clone 

# Open in Unity
# Unity 2021.3 LTS or newer required

# Install dependencies
# See Setup Guide for details
```

## Technology Stack

### Core Technologies

- **Game Engine**: Unity 2021.3 LTS
- **AR Framework**: Unity AR Foundation 5.x
- **Language**: C# (.NET Standard 2.1)
- **Platform**: Android (Unity Android Build Support)
- **IDE**: Unity Editor + Visual Studio or other Code Editor 

### APIs & Services

- **[Pegelonline API](apis/pegelonline.md)**: Real-time water level data
- **[Open-Meteo Elevation API](apis/elevation.md)**: Terrain elevation data
- **[Mock API](apis/mock-api.md)**: Testing and development

### Libraries & Packages

```
Unity AR Foundation 5.x
ARCore XR Plugin 5.x
UnityWebRequest (built-in)
Unity Location Services (built-in)
```

## Project Structure

to do 

## Architecture Overview

to do

## Key Components

### 1. Data Fetching Layer
- `API_WaterLevel.cs`: Fetches water levels from Pegelonline
- `API_Elevation.cs`: Gets elevation data
- `Location.cs`: Manages GPS positioning

### 2. Calculation Layer
- `FloodHeightManager.cs`: Calculates flood height at user position
- Combines water level, elevation, GPS, floor offset

### 3. Visualization Layer
- `ContentPlacement.cs`: Positions water plane in AR space
- `ARSessionOrigin`: Manages AR coordinate system
- Water material & renderer

### 4. User Interface
- `DebugPanel.cs`: Technical info display
- `BuildingLevel.cs`: Floor selection dropdown
- TextMeshPro UI elements

## Development Workflow

### 1. Setup Development Environment
See [Setup Guide](setup.md)

### 2. Make Changes
- Modify C# scripts
- Test in Unity Editor
- Build for Android

### 3. Test
- Unity Play Mode testing
- Android device testing
- See [Testing Strategy](testing.md)

### 4. Submit
- Create pull request
- Follow [Contributing Guide](contributing.md)

## Design Principles

### 1. Modularity
Each component has a single responsibility:
- API classes only handle data fetching
- Manager classes only handle calculations
- Placement classes only handle positioning

### 2. Separation of Concerns
```
Data Layer (APIs) 
    ↓
Business Logic (Managers)
    ↓
Presentation Layer (UI/AR)
```

### 3. Testability
- Mock API for testing without real data
- Debug panel for verification
- Demo mode for offline testing

### 4. Performance
- Update intervals (5 seconds for API calls)
- Efficient coroutines

## Common Development Tasks

### Adding a New Data Source

1. Create new API script (e.g., `API_NewSource.cs`)
2. Implement data fetching coroutine
3. Add static properties for data sharing
4. Integrate with `FloodHeightManager.cs`

### Modifying Water Visualization

1. Edit `ContentPlacement.cs`
2. Adjust calculation in `UpdateWater()`
3. Test with various elevation/water levels

### Adding UI Elements

1. Modify UI Canvas prefab
2. Create/update C# script for logic
3. Use TextMeshPro for text
4. Follow existing UI patterns

### Changing AR Behavior

1. Modify `ARSessionOrigin` settings
2. Adjust AR Foundation components
3. Test on actual device (AR doesn't work in editor)

## Debugging Tips

### Unity Console Logs

Enable detailed logging:
```csharp
Debug.Log("WaterHeight: " + waterHeight);
Debug.Log("Elevation: " + elevation);
```

### Debug Panel

Use the in-app debug panel:
- Shows all key values in real-time
- Verify calculations step-by-step

### Android Logcat

View device logs:
```bash
adb logcat -s Unity
```

### Common Issues

| Issue | Solution |
|-------|----------|
| API data not updating | Check coroutine is running |
| Water plane position wrong | Verify calculation in FloodHeightManager |
| AR tracking issues | Test on different surface/lighting |
| GPS not working | Test on actual device, not emulator |

## Next Steps

**For New Contributors:**
1. [Setup Development Environment](setup.md)
2. [Build Your First Version](building.md)
3. [Read Contributing Guide](contributing.md)

**For Understanding the System:**
1. [Architecture Deep Dive](architecture.md)
2. [Design Decisions](design_decisions.md)
3. [API Documentation](apis/pegelonline.md)

**For Testing:**
1. [Testing Strategy](testing.md)
2. [Error Handling](error_handling.md)

## Resources

- **Unity Docs**: [docs.unity3d.com](https://docs.unity3d.com)
- **AR Foundation**: [Unity AR Foundation Manual](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.0/manual/index.html)
- **Pegelonline**: [pegelonline.wsv.de](https://pegelonline.wsv.de)
- **C# Guide**: [Microsoft C# Docs](https://docs.microsoft.com/en-us/dotnet/csharp/)

## Getting Help

- **GitHub Issues**: Report bugs and request features
- **Discussions**: Ask questions, share ideas
- **Pull Requests**: Contribute code