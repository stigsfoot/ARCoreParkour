# ARCore Parkour Demos

A collection of demos from my GDE codelabs/talks covering:

* Unity3D AR Foundation (Beginner)
* Building your first ARCore Experience (Beginner)
* Augmented Images (Intermediate)
* Augmented Faces (Advanced)
* Cloud Anchors (Advanced)

_Quick note: I'll be adding stuff over time so if the demo is not fully moved over, check back._

# Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

* A supported ARCore device, connected via a USB cable to your development machine.
* ARCore 1.6 or later. This APK is normally automatically installed on the device via the Play Store. 
* Unity3D 2018.3.1f1 for Augmented Images or ARCore 101 Demo OR
* A development machine with Android Studio (v3.0 or later) for Sceneform Demo (Augmented Faces)
* A firebase account for Cloud Anchors Demo

## Running the demos

### For Augmented Images:

Open the project in Unity.

Verify you're building to Android. Also when building the app, make sure to include the augmented image scene located in `Assets > Scenes`.

Make sure your device is connected to your machine and then click `Build and Run`. Unity builds your project into an Android APK, installs it on the device, and launches it.

Print out the images located in `Assets > _Images` (or have it up on your monitor/screen)

As you move your device, the app automatically detects and tracks images from the set of reference images.

*be sure to star this repo or follow on Twitter for the other projects*
# Authors
Noble Ackerson - _Initial work via_ - [Google ARCore Docs](https://developers.google.com/ar/develop/unity/augmented-images/guide)
