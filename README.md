# Ice-cream-game

Instruction:
¡¡¡¡This game is an ice cream game. There are an ice cream man and some plyers in this game. First the ice cream man give score to each ingredient and then the other players will try to guess the price of ingredients. During the game, there will be ingredient card shown randomly and all the player should take an ice cream which contain that ingredient. The ice cream man will give the price of that ice cream. There are two screens (Assign the score(fridge), ice cream), and they are linked to each other.
¡¡¡¡
Short bullet point list of something miss:
1. After put the score on ingredient card, we do not make it to a certain position.
2. We show the player score on the bottom of the ice cream screen to test the code, in practical game this should not be shown.
3. When using the mouse to click the ¡°show ingredient¡±, it can only be effective in the central place but not all of the position. This is because the ¡°On Mouse¡± function can only be effect in the Mesh collider Cube. This means that the picture area is not the cube effect area and bigger than that.
4. There is no warning when the wrong score was put on the ice cream.
5. There is also no warning when the player choose a wrong ice cream which not contain the ingredient shown.


Script file name:
1. givescore.cs 
    Move the score onto the ingredient card and also onto the ice cream card. This function is used in ¡°Assign the score (fridge)¡± screen and ¡°ice cream¡± screen. We give this script to the score card. And then we can click the mouse on it and drag it to anywhere.
2. Chooseicecream.cs
This script have the same function with ¡°givescore.cs¡±.It can move the ice cream card to the select box. 
3. GoBack.cs
This function link the Assign the score screen to the ice cream screen by click the icon.
4. SeeFridge.cs
This fuction link the ice cream screen to the Assign the score screen which help the ice cream man to see the fridge and know the score of each ingredient.
5. Showingredient.cs
You can click on the show ingredient area to see the next ingredient. The ingredient card show randomly. Each time a new ingredient shown there will be a sign (New!) shown too. This is aimed to avoid a situation that a same ingredient card shown but you do not know.
6. ingredientData.cs
This script tend to remember the score of each ingredient that the ice cream man order. It works by judge the position of each score card, if it is on one of the ingredient card then we will give that ingredient this score data.
7. icecreamData.cs
This script use the data of ¡°ingredientData.cs¡±. We add all of the score of the ingredient which one ice cream contains together and save the data.
8. playerData.cs
In this script, we save data of which ice cream each player have, what is the total score of each player and what is the score of each ice cream. The last one comes from the ¡°icecreamData.cs¡±.

9. Remember.cs
We remember the data of which ice cream each player has and reput it to the place of selected box.

10. Showscore.cs
In this script, there is an icon in the screen of the fridge. By click it, you can decide whether to show the score of selected ice cream to the players.

