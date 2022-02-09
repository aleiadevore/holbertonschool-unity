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
  - Remap output becomes power of fresnal effect
- Setting pulse frequency
  - Create pulse speed property.
  - Output time (just time) and pulse speed into new multiply node.
  - Output multiply node into new sine node.
  - Use sine node output as remap's input
## 2 - Dissolve
### Resources
- YouTube: [DISSOLVE using Unity Shader Graph](https://youtu.be/taMp1g1pBeE)
### Steps
- Create simple noise for Alpha.
- Create scale property. Set default to 30 and use this for simple noise scale.
- Edit the [alpha clip](https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@7.1/manual/Alpha-Clipping.html) to control the speed.
  - Create speed property. Set default to .1
  - Create time node.
  - Create multiply node to multiply time by speed.
  - Output multiply to alpha clip threshold.