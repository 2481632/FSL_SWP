# Hardware Requirements

Information about hardware used for development and required for using AR Flood Visualization.

## Development Hardware

### Our Development Devices

The team used the following hardware during development and testing:

#### Primary Test Devices

**Device 1: Samsung Galaxy S23**
```
Model: Samsung Galaxy S23
Android Version: 14.0
Processor: Snapdragon 8 Gen 2
RAM: 8 GB
Display: 6.1" AMOLED, 1080x2340
ARCore: Supported ✓
```

**Device 2: Samsung Galaxy Tab S6 Lite**
```
Model: Samsung Galaxy Tab S6 Lite
Android Version: 13.0
Processor: Exynos 1280 / Snapdragon 720G (depending on variant)
RAM: 4 GB
Display: 10.4" TFT, 1200x2000
ARCore: Supported ✓
```

**Device 3: Nothing Phone (2a)**
```
Model: Nothing Phone (2a)
Android Version: 14.0
Processor: MediaTek Dimensity 7200 Pro
RAM: 8 GB / 12 GB
Display: 6.7" AMOLED, 1080x2412
ARCore: Supported ✓
```

## End-User Hardware Requirements

### Minimum Requirements

**Android Device Specifications:**

| Component | Minimum | Recommended |
|-----------|---------|-------------|
| **OS Version** | Android 11.0 (API 30) | Android 12+ |
| **ARCore** | Required | Latest version |
| **Processor** | Snapdragon 600 series | Snapdragon 700+ |
| **RAM** | 2 GB | 4 GB+ |
| **Storage Free** | 150 MB | 500 MB |
| **Display** | 720p | 1080p+ |
| **Camera** | Rear camera required | Good quality camera |
| **GPS** | Required | GPS + GLONASS |
| **Network** | 3G | 4G/5G |

### ARCore Compatibility

**Critical Requirement:**

The device MUST support ARCore. Check compatibility at:

- [Google's ARCore Supported Devices](https://developers.google.com/ar/devices)


### GPS Requirements

**For Accurate Positioning:**

- GPS/GLONASS/Galileo support
- Clear view of sky (outdoor use recommended)
- Modern GPS chip (post-2018 devices)

**Accuracy Expectations:**

- Horizontal: ±5-20 meters
- Vertical: ±10-30 meters (less reliable)
- Best results: Outdoors with clear sky

**GPS Limitations:**

- Tall buildings reduce accuracy
- Indoor use limited
- Urban canyons affect signal
- Weather can impact precision

### Camera Requirements

**For AR Tracking:**

- Rear-facing camera mandatory
- Minimum 8MP recommended
- Good low-light performance helpful
- Wide angle beneficial but not required

**AR Tracking Needs:**

- Textured surfaces for feature detection
- Good lighting (not too dark/bright)
- Stable camera movements

### Network Requirements

**Internet Connection:**

Required for:

- Fetching water level data (Pegelonline API)
- Getting elevation data (Open-Meteo API)
- Initial data loading

**Recommended:**

- 4G LTE or WiFi
- 5 Mbps+ download speed
- Low latency helpful


### Battery Requirements

**Power Consumption:**

AR apps are power-intensive:

- Average drain: 20-30% per hour
- Depends on device, brightness, network

**Recommendations:**

- Start with 50%+ battery
- Use power saving mode
- Reduce screen brightness
- Close background apps
- Consider portable charger for extended use

**Battery Optimization:**
```
Settings → Battery → AR Flood Viz
→ Optimize battery usage: On
→ Background restriction: Recommended
```

### Storage Requirements

**Installation:**

- App size: ~120 MB
- Cache: ~30 MB
- Total: ~150 MB initially

**During Use:**

- Temporary files minimal
- No large data downloads
- Cache can be cleared safely

## Development Workstation Setup

### For Unity Development

**Minimum Workstation:**
```
OS: Windows 10/11 or macOS 11+
CPU: Quad-core 2.5 GHz+
RAM: 16 GB
GPU: Any with 2GB VRAM
Storage: 256 GB SSD
Display: 1080p
```

**Recommended Workstation:**
```
OS: Windows 11 or macOS 12+
CPU: 8-core 3.0 GHz+ (i7/Ryzen 7)
RAM: 32 GB
GPU: NVIDIA RTX 3060 or better
Storage: 512 GB NVMe SSD
Display: 1440p or higher
Multiple monitors: Helpful
```

**Why These Specs:**

- Unity Editor is resource-intensive
- Building for Android requires memory
- Shader compilation needs GPU
- Large project files benefit from SSD

### Required Software
```
- Unity 2021.3 LTS (or compatible)
- Unity Hub
- Android SDK (via Unity or standalone)
- Android NDK (via Unity)
- JDK 8 or 11
- Git (version control)
- Visual Studio or other code editor
```

## Next Steps

- Check [Compatibility Guide](../user_guide/compatibility.md) for detailed device requirements
- Read about [Team](team.md) who developed this
- See [Future Work](future_work.md) for planned features

---

**Hardware Status**: Well-tested on modern Android devices  
**Platform Support**: Android only (iOS planned)  
**Last Updated**: February 2026