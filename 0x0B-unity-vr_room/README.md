# 0x0B-unity-vr_room
This directory contains files for a VR escape room.

## Progress log 12/6
- Locomotion is making user stand halfway into the ground
- GameObject at the end of raycast can interact with objects, but the actual hands can't
- Raycast arc looks gross. Mess with it
- The transition between valid color and invalid color is jarring. Make similar enough for smooth distinction while still being clearly distinct.
- Right now, the left hand is for locomotion while the right hand is for attempting to interact as a hand. To fix this:
  - [ ] First, just get it to work like this.
    - [ ] Determine why models aren't animated correctly
    - [ ] Determine why sphere collider on right isn't working
      - [ ] Try to make collider larger
  - [ ] Figure way to make raycast only exist when B button pressed

## Make it accessible
Once the basics are complete, try to:
- [ ] Create sound cues for interactable objects
- [ ] Check for color cues. Are they color blind safe colors?