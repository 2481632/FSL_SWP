# Overview

Welcome to the AR Flood App developer documentation. This guide is for developers who want to contribute to, extend, or understand the technical implementation of this project.

This developer guide covers:

- **Architecture**: How the system is structured
- **Setup**: Getting the development environment ready
- **APIs**: Integration with external services
- **Design Decisions**: Why we made certain technical choices
- **Testing**: Our testing strategies 
- **Error Handling**: Common error that might occur 


## Technology Stack

### Core Technologies

- **Game Engine**: Unity 2021.3 LTS
- **AR Framework**: Unity AR Foundation 5.x
- **Language**: C#
- **Platform**: Android (Unity Android Build Support)
- **IDE**: Unity Editor + Visual Studio or other Code Editor 

### APIs & Services

- **[Pegelonline API](apis/pegelonline.md)**: Real-time water level data
- **[Open-Meteo Elevation API](apis/elevation.md)**: Terrain elevation data
- **[Mock API](apis/mock_api.md)**: Testing and development


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


## Next Steps
For more detailed information, read the following sections:

[Setup Development Environment](setup.md)
[Architecture](architecture.md)
[Design Decisions](design_decisions.md)
[API Documentation](apis/pegelonline.md)
[Testing Strategy](testing.md)
[Error Handling](error_handling.md)
