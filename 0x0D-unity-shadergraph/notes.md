# Task Notes
## 0 - Glow
### Resources
- YouTube: [Unity tutorial](https://youtu.be/qTYOWRWuBQg)
## 1 - Animated Glow
### Resources
- Youtube: [Unity SHADERGRAPH Episode 7: Time](https://youtu.be/2fg8fdkS4Nw)
### Steps
- Began with base of Glow shader graph
- Creating pulse
  - Add time node to use sine time. This has a range from -1 to 1
- Setting max and min
  - Take input from min and max and put them into a vector 2 node.
  - Create remap node with sin as input.
  - Take vector 2 with min and max and use the output for the output range for remap node.
  - Set input range to -1 and 1, since that's the range of sine
- Setting pulse frequency