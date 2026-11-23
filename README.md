# MG7
## Devlog
In TreeOfBirds, when the player gets close enough, the sparrows pop out of the tree. Using an array makes things easier by storing the sparrows so we can just loop through each bird instead of checking them one by one. The vectors are used to find the distance between the player and each bird using the method function Vector3.Distance(). For each frame, it checks if the player is close enough to a bird, and if the distance is less than the interaction distance, the bird becoms actice and the pop-up animation starts up. 

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
