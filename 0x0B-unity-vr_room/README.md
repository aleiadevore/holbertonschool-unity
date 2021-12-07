# 0x0B-unity-vr_room
This directory contains files for a VR escape room.
- [0x0B-unity-vr_room](#0x0b-unity-vr_room)
  - [Progress log](#progress-log)
    - [12/7](#127)
    - [12/6](#126)
  - [Make it accessible](#make-it-accessible)
  - [References](#references)

## Progress log
### 12/7
**Today's Focus:**
Get hands able to interact
- [ ] Locomotion works, but raycast flashes as though it can't tell if an area is valid or not
- [ ] Hand animation works for right but not left
  - [ ] Base hand visible in addition to model. Do I have it duplicated somewhere?
- [X] Still standing halfway through floor, but it looks like this is because my feet are on world ground instead of floor of level.
  - Switching tracking from device to floor seemed to solve issue.
- [X]**Hands can grab things!**
  - [ ] All interactables can now be picked up
  - [ ] Need to go through and see what should be picked up
- [ ] Physics issues
  - [ ] Headset can walk through solid objects
  - [X] Impossible to teleport through solid objects
- Sphere collider in awkward placement for hand. Move to more center
### 12/6
- [X] Locomotion is making user stand halfway into the ground
- [ ] GameObject at the end of raycast can interact with objects, but the actual hands can't
- [X] Raycast arc looks gross. Mess with it
- [X] The transition between valid color and invalid color is jarring. Make similar enough for smooth distinction while still being clearly distinct.
- Right now, the left hand is for locomotion while the right hand is for attempting to interact as a hand. To fix this:
  - [X] First, just get it to work like this.
    - [ ] Determine why models aren't animated correctly
    - [X] Determine why sphere collider on right isn't working
      - [X] Try to make collider larger
  - [ ] Figure way to make raycast only exist when B button pressed

## Make it accessible
Once the basics are complete, try to:
- [ ] Create sound cues for interactable objects
- [ ] Check for color cues. Are they color blind safe colors?
- [ ] Raycast continually flashing between valid and nonvalid is nausiating. Figure out what's going on with it.

## References
Videos I used as tutorials
- [UNITY XR INTERACTION TUTORIAL PART 6: Using the Interactable Events](https://www.youtube.com/watch?v=KcSGf2DKQhU&ab_channel=DanielStringer)
- [Introduction to VR in Unity - PART 1 : VR SETUP](https://www.youtube.com/watch?v=gGYtahQjmWQ&ab_channel=Valem)
  - Getting hand grab working
- [Introduction to VR in Unity - PART 2 : INPUT and HAND PRESENCE](https://www.youtube.com/watch?v=VdT0zMcggTQ&ab_channel=Valem)
  - Getting hand animation working correctly
