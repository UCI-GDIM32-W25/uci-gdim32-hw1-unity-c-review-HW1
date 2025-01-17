[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Objects:
- UI
    - Seeds planted UI
        - Attributes: text
        - Actions: count goes up when player plants a seed
    - Seeds remaining UI
        - Attributes: text
        - Actions: count goes down when player plants a seed 
- Player
    - Attributes
        - Bunny sprite
- Plants
    - Prefab 

Actions:
- Player’s movement
    - horizontal/vertical (WASD keys) 
- Planted Seeds (limited to 5)


Relations between objects and actions
- As the player engages in planting seeds, there is a direct interaction between the player's actions and the UI components. Each time a seed is planted:
    - The Seeds Planted UI updates to increase the count by one.
    - Simultaneously, the Seeds Remaining UI updates to decrease the count by one.
- This interactive mechanism continues until the player has planted all available seeds, at which point:
    - The ability to plant further seeds is disabled, and the player cannot decrease the Seeds remaining count below zero.
- Regarding player movement and UI interaction:
    - If the player moves to the edge of the game frame, the game’s camera or viewport is designed to prevent scrolling or moving outside the designated game area. This ensures that the player remains visible and the focus of the gameplay at all times, maintaining engagement and preventing disorientation.
    - Fixed main camera 

## Devlog
In the initial planning phase of HW1, the game was designed around a player character and a UI system that interactively displayed the number of seeds planted and seeds remaining. The player, represented by a bunny sprite, was equipped with the capability to plant a maximum of five seeds, which directly influenced the UI components responsible for displaying the seed counts. The implementation of the player’s attributes and actions was encapsulated within the Player class in Unity. The player’s movement was controlled through the Update() methose, which processed input for horizontal and vertical movement using the WASD keys. This method updated the _playerTransform.position continuously, allowing for fluid movement within the game environment. 

Additionally, the UI was designed to have two primary functions: displaying the number of seeds planted and the number of seeds remaining. These functionalities were realized through the PlantCountUI class. One method was “UpdateSeeds(int seedsLeft, int seedsPlanted)” where it is crucial as it receives updated values whenever a seed is planted and reflects these changes on the UI. Each call to UpdateSeeds changes the text of _plantedText and _remainingText to display current values, directly linking player actions to visual feedback on the UI. And another core method is PlantSeed() where the game logic for planting a seed is implemented. When executed, it checks if seeds are available (_numSeedsLeft>0). If true, it decrements _numSeedsLeft, increments _numSeedsPlanted, instantiates the seed prefab at the player’s current position, and updates the UI via a call to _plantCountUI.UpdateSeeds(_numSeedsPlanted, _numSeedsLeft). This method demonstrates a direct implementation of the planned interaction where planting a seed changes the counts on the UI. 

The detailed setup and interaction between Player and PlantCountUI classes within the Unity environment effectively translate the initial plan into a functional game module. By citing specific methods like PlantSeed() and UpdateSeeds(), and linking them with GameObjects like Player, Text_SeedsPlatedNum, and Text_SeedsRemainingNum, the connection between the conceptual design and practical implementation is clearly demonstrated, showing a coherent development process from plan to execution. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for answering the prompt and formatting everything well!
