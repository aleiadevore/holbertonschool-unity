# 0x0C-unity-ar_slingshot_game

## Log
### 1/9/22
- Plane detection is working, but I'm unsure how to select one specific plane.
- Following [TOUCH CONTROLS in Unity!](https://www.youtube.com/watch?v=bp2PiFC9sSs&ab_channel=Brackeys) tutorial to work through how to select object with a touch.
  - Used tutorial to create [this script](Assets/Scripts/testCube.cs) for learning Input.GetTouch
- The debugging plan:
  - [ ] Test basic tap by changing cube's material
  - [ ] Only change material when cube is touched
  - [ ] Find way to change plane material on tap
  - [ ] Once I can isolate selected material, use for loop to disable all other planes
- **Issue**:
  In all of my brilliance, I didn't add the scene to github before trying to mass upload the project, so I'm going to have to redo the initial setup.
  - Tested on device, still seems to work with all functionality previously set up.
- Switched plane detection to only detect horizontal plane because that's all I'll need
- ~~Cube doesn't show up, but that's probably covered in basic tutorial~~ Cube now showing up. Issue was that it wasn't in a place where the camera could easily see it.
  - Cube moving, but I don't know where it moved to.
- Canvas isn't showing up.

