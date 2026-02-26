# Testing Strategy

Comprehensive testing approach for AR Flood App.

## Testing Levels

### 1. Code Review Testing

**When:** Before merging any code

**Process:**

Check code for:

- Obvious bugs
- Code style consistency
- Proper error handling
- No debug/test code left in


### 2. Unity Play Mode Testing

**When:** During development, before building to device

**What We Test:**
- Logic and calculations
- UI behavior (non-AR parts)
- Data parsing
- Error handling

**What Doesn't Work:**
- AR tracking (needs device)
- GPS (needs device)
- Camera (needs device)


### 3. Device Testing (Primary Method)

**Our Test Devices:**

1. **Samsung Galaxy S23** 
2. **Nothing Phone (3a)** 
3. **Samsung Galaxy Tab S6 Lite** 

**Why Multiple Devices:**
- Different performance levels
- Different screen sizes
- Different Android versions
- Different manufacturers

### Testing Scenarios

#### AR Tracking Quality

**Test Environments:**
- Indoor (poor lighting)
- Outdoor (bright sun)
- Outdoor (overcast)
- Various surface types


**Expected Results:**
- AR tracking stable on textured surfaces
- Water plane stays positioned correctly
- No excessive jitter/shaking
- Tracking recovers after quick movement
- Works in various lighting (with degradation in poor light)


#### GPS Accuracy

**Test Locations:**
- Outside
- Indoor

**Expected Results:**
- GPS lock within 30-60 seconds
- Coordinates accurate within ±10 meters
- Updates as you move
- Elevation reasonable for location


#### API Integration

**Test with Mock API:**

- Test without real floods
- Faster development iteration
- Controllable test scenarios
- Works offline
- No API rate limits

how:

- Change values in the mock API and watch how the water plane changes height 

**Test with Real API:**

- check if GPS calculations find the correct nearest station and wether the flood level is displayed correctly


#### Floor Selection

**Expected Results:**
- Dropdown shows all floor options
- Water plane adjusts correctly (±3m per floor)
- Debug panel shows correct offset
- No crashes with extreme floors


#### Demo Mode

**Expected Results:**
- Works offline
- Uses mock water levels
- All features functional
- Good for presentations/testing


#### Not tested yet: Edge Cases

**Situations that haven't been tested:**

1. **Very High Elevation** (mountain)
    - Launch at 1000m+ elevation
    - Verify calculations correct
    - Water should be far below

2. **Very Low Elevation** (coast)
    - Launch at sea level
    - Verify calculations correct
    - Water may be above

3. **Rapid Movement**
    - Walk quickly while using app
    - Verify AR tracking recovers
    - Check GPS updates




