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
OnMouseEnter(): To know if mouse is moving onto the object, change the color to blue 
OnMouseExit(): To know if mouse is moving away from the object, change the color back to the original color.
OnMouseDown(): To know if the mouse is clicked, and then keep the object moving with mouse.


2. Chooseicecream.cs
This script have the same function with ¡°givescore.cs¡±.It can move the ice cream card to the select box. 
Functions are same with "givescore.cs"
3. GoBack.cs
This function link the Assign the score screen to the ice cream screen by click the icon.


4. SeeFridge.cs
This fuction link the ice cream screen to the Assign the score screen which help the ice cream man to see the fridge and know the score of each ingredient.
5. Showingredient.cs
You can click on the show ingredient area to see the next ingredient. The ingredient card show randomly. Each time a new ingredient shown there will be a sign (New!) shown too. This is aimed to avoid a situation that a same ingredient card shown but you do not know.
6. ingredientData.cs
This script tend to remember the score of each ingredient that the ice cream man order. It works by judge the position of each score card, if it is on one of the ingredient card then we will give that ingredient this score data.

GameObject m_obj1 to m_obj4: 4 kinds of score card(+20.-20.+10.-10) 
GameObject ing1 to ing8: 8 kinds of ingredient
static public int chocolateSauce and the follow 7 : the score of each ingredient
int choScoreChange and the follow 7: signals to know if the score of the ingredient has been changed
  
7. icecreamData.cs
This script use the data of ¡°ingredientData.cs¡±. We add all of the score of the ingredient which one ice cream contains together and save the data.

icecream1 and the follow 27 : The score of each ice cream, this is calculated by the following ingredient score which it contains
static public int chocolateSauce and the follow 7: To remeber the score of each ingredient, for calling these data when come back to the fridge

8. playerData.cs
In this script, we save data of which ice cream each player have, what is the total score of each player and what is the score of each ice cream. The last one comes from the ¡°icecreamData.cs¡±.

GameObject player1 to player4:  represent the three players
GameObject ice1 and the follow 27: represent the 28 ice cream cards on the table
icePlace1 ,icePlace2....: the signal that means the place 
public int player1totalscore: the total score that player 1 have(same with player 2 and 3)
placeChange1 : signal to show whether the place of one ice cream card is given to one of the players
begin(): get the position of the ice cream card,and call for the "position()"function
position(): To know if the ice cream card is moved onto the selected box of players,and then change the signal number (icePlace) to show the situation
totalsore(): add all of the ice cream of one player

9. Remember.cs
We remember the data of which ice cream each player has and reput it to the place of selected box.

void putsignal1():  put the signal of each player in turn
    
score(): call for the giveprice function the give the score to the ice cream


10. Showscore.cs
In this script, there is an icon in the screen of the fridge. By click it, you can decide whether to show the score of selected ice cream to the players.

