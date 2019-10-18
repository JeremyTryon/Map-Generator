# CIS598
//This is for the CIS598 class


A program that allows users to create maps for fantasy worlds to be used in table top games. The program works as a tiling engine with each tile representing a section of land. Each section is initially blank and can be filled in was a color that correlates to a land type (grass, mountain, desert, etc.). The maps can be manually built or generated using the random generation method. The project also contains a feature where the program with generate a map from incomplete data. It accomplishes this by taking in the already filled data and using an algorithm calculates what tile colors should be used to fill in the rest of the map. The worlds are all saved locally using Serialization. When the map is being used, there is a view for the person running the game and for the players. The person running the game can choose which tiles the players can view.
