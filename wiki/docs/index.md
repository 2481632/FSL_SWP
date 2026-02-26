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

- **[Pegelonline API](developer_guide/apis.md)**: Real-time water level data
- **[Open-Meteo Elevation API](developer_guide/apis.md)**: Terrain elevation data
- **[Mock API](developer_guide/apis.md)**: Testing and development




## Development Workflow

### 1. Setup Development Environment

See [Setup Guide](developer_guide/setup.md)

### 2. Make Changes

- Modify C# scripts
- Test in Unity Editor
- Build for Android

### 3. Test

- Unity Play Mode testing
- Android device testing
- See [Testing Strategy](developer_guide/testing.md)


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

[Setup Development Environment](developer_guide/setup.md)
[Architecture](developer_guide/architecture.md)
[Design Decisions](developer_guide/design_decisions.md)
[API Documentation](developer_guide/apis.md)
[Testing Strategy](developer_guide/testing.md)
[Error Handling](developer_guide/error_handling.md)
