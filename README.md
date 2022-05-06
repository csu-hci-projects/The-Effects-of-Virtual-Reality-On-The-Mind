# The-Effects-of-Virtual-Reality-On-The-Mind

## Instructions: ##

1. Install Unity and Unity Hub
2. Aqcuire an Oculus Quest 2
3. Install the following packages in Unity
    * Oculus XR Plugin
    * Openxr plugin
    * XR interaction toolkit
    * XR plugin manager
    * Oculus integration

## Create the environment: ##

1. Create an empty named environment
    1. Inside this environment create an XR Origin (Action-based)
    2. Create a camera offset as a child of this (this will spawn a camera linked to the headset and a camera for each controller/hand)
2. Create a plane to act as a floor
3. Create a room using cubes as walls
    1. Fill the room with cubes and spheres
    2. Give each cube and ball an XR interactable, rigibody, and respective collider
4. Create a "hall" using the same method
    1. Inside the hall place a rectangle in the floor
    2. Create alternating lines on the back wall
    3. Place a target at the end of the hall
    
## Attatch Scripts ##

1. Attatch the correctly named scripts to the player controller attatched to the XR Origin
2. Attatch the JumpPad script to the rectangle placed in the hall

