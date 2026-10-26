# Quimicefa (AR)

Augmented reality mobile game made in Unity where you solve chemistry problems with the phone's camera. It uses printed cards: some stand for chemical elements and one for the task. To complete it, you build the requested compound by putting element cards together and bringing them close to the task card.

![Unity](https://img.shields.io/badge/Unity-000000?style=flat-square&logo=unity&logoColor=white) ![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white) ![Android](https://img.shields.io/badge/Android-3DDC84?style=flat-square&logo=android&logoColor=white)

**Android:** [APK in Releases](../../releases/latest) · **Gameplay video:** [YouTube](https://www.youtube.com/watch?v=Jvo3VOHDayM)

## Project

Opens with **Unity 2022.3.62f3** (`ProjectSettings/ProjectVersion.txt`): add the folder in Unity Hub. The game was made in 2021 with an older Unity version and kept as a `.unitypackage`; this project tree was rebuilt from that package. Packages don't carry project settings, so the tags and the scene list in Build Settings were restored from the scenes. Scene: `SampleScene`. Build target: Android.

Tracking uses **Vuforia Engine**, which isn't on the Unity registry: add it from the [Vuforia developer portal](https://developer.vuforia.com/downloads/sdk) and paste your own license key into `Assets/Resources/VuforiaConfiguration.asset` (the original key was removed). The image target database is `Assets/StreamingAssets/Vuforia/dsh2021.dat`, and its target images are in `Assets/Editor/Vuforia/ImageTargetTextures/dsh2021/`.

Not included: the Vuforia migration scripts (`Editor/Migration`, part of Vuforia Engine) and the TextMesh Pro examples.

## License

My own code, scenes and models are under the [MIT License](LICENSE). Unity's TextMesh Pro resources keep their own license (Unity Companion License).

Previously part of [Trabajo-Realidad-Aumentada](https://github.com/Jesus-md-dev/Trabajo-Realidad-Aumentada), together with Monster War.

More about my games at [jzmarquez.com](https://jzmarquez.com/).

Coursework from my Computer Engineering degree at the University of Cádiz (Escuela Superior de Ingeniería).
