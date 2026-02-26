## Key Components

### 1. Data Fetching Layer

- `API_WaterLevel.cs`: Fetches water levels from Pegelonline
- `API_Elevation.cs`: Gets elevation data
- `Location.cs`: Manages GPS positioning

*For more information, refer to the [API section](apis/elevation.md).*

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
