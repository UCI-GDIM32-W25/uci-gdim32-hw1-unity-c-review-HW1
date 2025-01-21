[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- Player (bunny)
  - Player aesthetics
    - Bunny (white/purple)
- Seeds/Plant
  - Plant aesthetics 
    - Green leaves
- UI
  - Seeds planted
  - Seeds remaining

Attributes/Actions:
  - Player movement:
    - Actions:
      - WASD and space key to plant
      - Plantings / pressing space 
      - Seed prefab to create a clone when player presses space 
      - UI to change when player presses space 
  - UI
    - Depending on how many seeds are planted, the UI changes the number of seeds remaining/planted
    - When player plants a seed:
      - Seeds planted UI goes up
      - Seeds remaining UI goes down 
  - Plants:
    - When player presses space, the plant is placed at the player’s location 
    - Only one seed at a time
    
Affect:
- The plants are planted specifically at the player’s location
- After planting 5 seeds, the player will not be able to plant anymore
- The player is limited to plant

## Devlog
The first part of my notes connect to the objects in the game, which included the player, the seeds, and the UI. The descriptions relate to their sprites. For instance, the player has a bunny sprite, and the seeds have a seed sprite. Finally the UI relates to the text in the game. Next I focused on the actions, such as the WASD movement, which can be found in the Update function in the player class. Another action, pressing the space key, is represented through the PlantSeed method. This method is specifically called with GetKeyDown so that players won't continuously spawn seeds when they hold down the space bar. For the "Action" sections of my notes: Inside the PlantSeed method, the seed GameObject is instantiated to "spawn" a seed. It's transform position was also set to the player's transform position so that it can spawn where the player is located. The PlantCountUI's UpdateSeeds method was also called inside the PlantSeed method so that the UI will also update when a seed is planted. The _numSeedsLeft and _numSeedsPlanted variables are also updated in the PlantSeed method and then serve as arguments for the UpdateSeeds method. Finally, everything in the PlantSeed method is placed in an if statement that will only work if the varibble _numSeeds is greater than 0; this variable descreases when PlantSeed is called too. Since _numSeeds is set to 5, once the player places seeds five times, then they will no longer be able to.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting the attributes and actions that you wrote about for each object to the code that you implemented. :)

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
