[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

UI
    Seed counter (planted and remaining)
        Planted text
            Every time something is planted, add 1 
        Remaining text
            Every time something is planted, subtract 1 to a limit of 0
Plant Prefab
    Plant sprite
    Can be planted if Seeds remaining counter >0
    Can only be created by the player
    Only 5 can exist
Bunny (Player)
    Bunny sprite
    Can move with WASD
    Plant seeds with Space bar
        Adds a plant prefab where the bunny is located IF there’s seeds remaining
        If no seeds remaining, cannot plant (nothing happens)
    Updates UI with changes to seed count and seeds planted


## Devlog

I first decided to implement the UI in the class called PlantCountUI. This class only had a method to update the text in the TMP_text objects that were children of the canvas game object. This method takes in the values for number of seeds planted and the number of seeds remaining and updates the UI with those values. The Player script can call this method whenever the player plants. Next, I set up the plant prefab by creating a sprite object in the scene and setting its sprite to a plant from the provided spritesheet. After, I saved this as a prefab and removed it from the scene. The plant does not need to do anything, so no script was made for it. Finally, I worked on the player. I implemented movement by checking the WASD inputs and creating a vector to store the desired direction of movement. I then added to the current position this vector multiplied by the speed as well as the time that has passed in the last frame. I also checked for inputs by the spacebar, but since we don't want to plant each frame the space bar is held, I used the GetKeyDown function to only call the PlantSeed method when the spacebar is first pressed down. This method checks if there are any seeds left to plant, and if so it deducts one from the seeds left, adds one to the seeds planted, and instantiates the prefab created earlier. After all the changes, it calls the mehod in the UI to update the values on screen. All of this fully implements what I wrote out in the break-down.




## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
