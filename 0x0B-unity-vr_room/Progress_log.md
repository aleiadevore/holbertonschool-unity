# Progress log
## 12/10
- [X] Door works!
- Idea for walls:
  - Create canvas of black screen
  - When rigidbody around camera hits something, trigger black screen
  - Make sure to check that it isn't the cube around door
- Tested trigger with gameobject dissappearing.
  - It is getting triggered, so why won't the canvas show up?
    - Canvas now shows up at beginning, but disappears and does not reappear
    - Probably best to switch to method of using sphere around head with inverted material, similar to fade to black method of 360 video
      - Easier option: make box around with 6 cubes
  - [X] Need to make radius smaller
- [X] **Blackout Works!**
  - Rigidbody/capsule collider around camera triggers cube make of 6 GameObject cubes to appear around camera
- For advanced door:
  - Instead of any trigger, check that it has tag/name for specific key
## 12/7
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
- [ ] Sphere collider in awkward placement for hand. Move to more center
## 12/6
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
