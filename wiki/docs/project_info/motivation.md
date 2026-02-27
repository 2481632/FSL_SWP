# Project Motivation

Why we built AR Flood Visualization and the problem it solves.

## The Problem

### Abstract Flood Data is Hard to Understand

Current flood information systems have significant limitations that prevent people from truly understanding their personal risk:

**1. Gauge Readings (Pegelstände) are Abstract Numbers**

- Show water levels as numbers like "245 cm over gauge zero"
- Numbers are meaningless without context
- No connection to your personal environment
- Requires understanding of reference systems (Pegelnull, Normal-Null)
- Most people can't translate "3460 cm over NN" to real-world impact

**2. Flood Maps are Static and Generic**

- Show general flood zones, not your specific location
- Don't account for local terrain differences (small hills, basements, floor levels)
- Often outdated or based on historical models
- Hard to interpret

**3. Lack of Visual Intuition**

- Hard to assess personal risk from numbers alone
- Can't visualize the impact on your home/neighborhood
- Abstract measurements don't convey urgency
- People consistently underestimate flood danger

### Real-World Impact of Poor Flood Visualization

When people can't visualize flood risk, it leads to:

**Poor Preparedness:**

- Don't know if they're actually at risk
- Underestimate how high water will reach
- Don't prepare adequately (sandbags, moving valuables)
- Miss opportunity for preventive measures

**Delayed Evacuation:**

- Underestimate flood height until it's too late
- Don't leave early enough
- Get trapped in dangerous situations

**Safety Risks:**

- Put themselves in danger by staying too long
- Try to drive through flooded areas
- Don't understand fast-rising water danger
- Unnecessary injuries and casualties

## Our Solution

### AR Visualization Makes Flood Data Tangible

**The Core Idea:**

> Point your phone at your surroundings and **see exactly where flood water would reach** in augmented reality.

Instead of reading "Water level: 3460 cm over Normal-Null", you **see** a water plane at knee-height in your living room.

### How It Works

1. Open app at your location
2. Camera shows your surroundings
3. Water plane appears showing flood water level
4. Select your floor (basement, ground, 1st floor, etc.)
5. Instantly see if you're safe or at risk

### Key Benefits

- immediate understanding 
- personalized to your exact location


## Use Cases

### 1. Personal Safety Assessment

**Scenario:** You live near the Elbe river and hear flood warnings on the news. Water level is rising.

**Without our app:**

- News: "Elbe at 634 cm in Dresden"
- You: "Is that bad? Should I evacuate?"
- Confusion, anxiety, unclear risk

**With our app:**

1. Open app at your home
2. See AR visualization of flood level
3. Water plane appears 50cm below your window
4. You're on ground floor
5. **Decision: Evacuate immediately**

**Result:** Informed, confident decision about your safety

---

### 2. Education & Awareness

**Scenario:** teaching about flood risk

**With our app:**

1. Use demo mode with adjustable water levels
2. Show students: "This is what 1m of flooding looks like"
3. Increase level: "This is 2m, this is 3m"
4. Demonstrate how elevation matters

**Result:** Students understand flood risk concretely, not abstractly


## Why AR?

### The Power of Augmented Reality

**1. Spatial Understanding**

- See flood risk in context of your actual environment
- Understand height relationships intuitively
- No need for mental 3D visualization
- Direct comparison: flood vs. your surroundings

**2. Immersive & Memorable**

- More impactful than maps or numbers
- Creates emotional connection to risk
- Unforgettable experience
- Changes behavior through vivid visualization

**3. Accessibility & Ubiquity**

- Everyone has a smartphone
- No special equipment needed
- Works anywhere, anytime (with internet)
- Simple to use, no training required


## The Vision

### What We're Building Toward

**Short-term:**

- Functional AR flood visualization
- Real-time water level data
- User-friendly mobile app
- Predictive modeling (24-48h forecasts)

**long-term:**

- Historical flood overlays
- Multi-location comparison
- Notification system
- Offline mode


## Technical Innovation

### Challenges We Solved

**1. Data Integration**

- Combined three data sources: water levels, GPS, elevation
- Different units, reference systems
- Real-time updates
- Robust error handling

**2. Coordinate System Conversion**

- GPS coordinates (lat/lon)
- Elevation above sea level
- Gauge reference points (Pegelnull)
- Unity AR coordinate system

**3. AR Positioning**

- Position water plane at exact height
- Account for camera height
- Account for floor levels
- Stable tracking despite GPS drift

**4. User Experience**

- Simple interface despite complex calculations
- Debug panel for transparency
- Demo mode for testing/education
- Works on range of devices


## Why We Built This

### Personal Motivation

As computer science students, we wanted to:

- **Apply our skills for social good**
- **Tackle a real-world problem**
- **Learn AR development**
- **Make a meaningful impact**

### Development Journey

**November 2025:** Project conception, Technology exploration  
**December 2025:** Mock API , MVP Development  
**January 2026:** Real API integration, refinement  
**February 2026:** Documentation

--- 

## Next Steps

- Learn about the [Team](team.md) behind this project
- Understand our [Hardware](hardware.md) requirements
- See our [Future Work](future_work.md) plans
- Try the app: [Installation Guide](../user_guide/installation.md)