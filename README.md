# What is UnityEssentials?
> UnityEssentials is a collection of various scripts I've compiled over years of working with Unity. I've spent a lot of time debugging, researching, and programming various topics and I want to make them open to the public in hopes it can help you; beginner or pro alike.

## Code Organization Structure
- **Beginner** files and scripts will use the default unity input system, and rarely involve any kind of programming patterns. I try to keep them as simple as possible and give them a very specific goal to solve a single problem well.
- **Advanced** files and scripts will use the new input system, and will usually involve multiple programming patterns and SOLID principles. 
- Scripts are split into 2D and 3D respectively.

<ins>A beginner-focused, first person camera for a 3D game would for instance be found in Scripts/Beginner/3D/Camera/.</ins>

## Things not covered or utilized
Dependency injection will not be used as most of the software available to do this in unity is 3rd party and costs money. Dependency inversion as a SOLID principle therefore cannot be utilized as Unity doesn't serialize interfaces - you are more than free to implement Dependency Injection yourself, but expect some hard-coupled code in both beginner and advanced scripts alike when viewing.

