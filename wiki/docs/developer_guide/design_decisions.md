# Design Decisions

## Engine and Tools

### Unity

We decided to use Unity as our development engine. While WebAR was considered as an alternative during the initial planning phase, we ultimately chose Unity due to its superior performance and smoother operation across target devices.

However, for similar projects or reproductions, we recommend using WebAR instead, as it is fully sufficient for this use case, offers better compatibility since it runs directly in the browser, and is significantly more lightweight compared to Unity

### Unity IDE

Since we decided to use Unity as our engine, the natural choice for our development environment was the Unity Editor. While it integrates seamlessly with the engine itself, we were not entirely satisfied with it, as the editor feels overloaded with features and is prone to bugs, which occasionally impacted our development workflow.

### AR Mobile Template

Within the Unity Editor, we utilized the [AR Mobile template](https://docs.unity3d.com/Packages/com.unity.template.ar-mobile@1.0/manual/index.html), as it comes with essential AR functionalities already integrated and working out of the box.

## Plattform

As our target platform, we chose modern Android devices, as all team members own one, making testing as straightforward as possible. Additionally, compiling and sideloading on iOS is significantly more complex. For more information regarding hardware compatibility, refer to the [compatibility section](/user_guide/compatibility/).

## APIs

For more information, refer to the [API section](apis/elevation.md).

## Featues

### Displaying Only Current Data at This Stage

The ultimate goal of the project is to visualize data from both the past and the future. However, due to time constraints, we focused on a selected set of functionalities and decided that the first step should be to display current data in order to prove the fundamental concept of the application.


## Design and UI

### Water Visualization

Initially, we represented the water as a simple blue plane. However, we quickly realized that water in a flood simulation should appear threatening and murky rather than giving off "pool vibes". Since the Unity Asset Store already offers high-quality water templates, we decided to utilize one of them: [Water Shaders V2.x](https://assetstore.unity.com/packages/vfx/shaders/water-shaders-v2-x-149916).


### UI

We aimed to keep the UI as simple and lightweight as possible while still providing all relevant information. To achieve both, we implemented a debug overlay that allows the user to toggle between a clean view and a view displaying detailed debug information.
