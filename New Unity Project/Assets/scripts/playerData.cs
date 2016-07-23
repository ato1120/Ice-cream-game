using UnityEngine;
using System.Collections;


/*INSTRUCTION
 * This function is to save the Data of each player, which include the ice cream they have, the total socre they have, and the score of each ice cream
 * we give a sign (icePlace1,....)to each ice cream card to show which place they are at.(0= table, 1=player1,2=player2,3=player3)
 * By this way, we can know all of the situation of all the ice cream card, so that we know which ice cream every player have
 * We use a function (position )to decide where the ice cream card is.
 * To avoid the recalculate of the total score, we clear the value of total score before every update.
 * To get the score of each ice cream, we use the static value in Function "iceceramData". 
 * To calcualte the total score, we just add the score of each ice cream to the totalscore.
 */
public class playerData : MonoBehaviour {


    GameObject player1;
    GameObject player2;
    GameObject player3;

    GameObject ice1;
    GameObject ice2;
    GameObject ice3;
    GameObject ice4;
    GameObject ice5;
    GameObject ice6;
    GameObject ice7;
    GameObject ice8;
    GameObject ice9;
    GameObject ice10;
    GameObject ice11;
    GameObject ice12;
    GameObject ice13;
    GameObject ice14;
    GameObject ice15;

    //the position of each icecream(0= table, 1=player1,2=player2,3=player3)
    public int icePlace1 = 0;//ice cream1 place
    public int icePlace2 = 0;
    public int icePlace3 = 0;
    public int icePlace4 = 0;
    public int icePlace5 = 0;
    public int icePlace6 = 0;
    public int icePlace7 = 0;
    public int icePlace8 = 0;
    public int icePlace9 = 0;
    public int icePlace10 = 0;
    public int icePlace11 = 0;
    public int icePlace12 = 0;
    public int icePlace13 = 0;
    public int icePlace14= 0;
    public int icePlace15 = 0;


    public int player1totalscore = 0;
    public int player2totalscore = 0;
    public int player3totalscore = 0;


    //the size of the player box
    double halfXsize = 11.4;
    double halfYsize = 5.6;

    public int calculateTime = 0;

    public int placeChange1 = 0;
    public int placeChange2 = 0;
    public int placeChange3 = 0;


    // Use this for initialization
    void Start () {

        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
        player3 = GameObject.Find("player3");

        ice1 = GameObject.Find("ice cream1");
        ice2 = GameObject.Find("ice cream2");
        ice3 = GameObject.Find("ice cream3");
        ice4 = GameObject.Find("ice cream4");
        ice5 = GameObject.Find("ice cream5");
        ice6 = GameObject.Find("ice cream6");
        ice7 = GameObject.Find("ice cream7");
        ice8 = GameObject.Find("ice cream8");
        ice9 = GameObject.Find("ice cream9");
        ice10 = GameObject.Find("ice cream10");
        ice11 = GameObject.Find("ice cream11");
        ice12 = GameObject.Find("ice cream12");
        ice13 = GameObject.Find("ice cream13");
        ice14 = GameObject.Find("ice cream14");
        ice15 = GameObject.Find("ice cream15");

    }

    // Update is called once per frame
    void Update () {

        begin();
        totalscore();
        print("player 1 total score=" + player1totalscore.ToString("f4")
                  + "   player 2 total score=" + player2totalscore.ToString("f4")
                  + "   player 3 total score=" + player3totalscore.ToString("f4"));

        player1totalscore = 0;//clear the total score every update
        player2totalscore = 0;
        player3totalscore = 0;
	}
    


    //get the position and call for the position function 
    void begin()
    {
        Vector3 ice1_postion = ice1 .transform.position;
        float x1 = ice1_postion.x;
        float y1 = ice1_postion.y;
        Vector3 ice2_postion = ice2.transform.position;
        float x2 = ice2_postion.x;
        float y2 = ice2_postion.y;
        Vector3 ice3_postion = ice3.transform.position;
        float x3 = ice3_postion.x;
        float y3 = ice3_postion.y;
        Vector3 ice4_postion = ice4.transform.position;
        float x4 = ice4_postion.x;
        float y4 = ice4_postion.y;
        Vector3 ice5_postion = ice5.transform.position;
        float x5 = ice5_postion.x;
        float y5 = ice5_postion.y;
        Vector3 ice6_postion = ice6.transform.position;
        float x6 = ice6_postion.x;
        float y6 = ice6_postion.y;
        Vector3 ice7_postion = ice7.transform.position;
        float x7 = ice7_postion.x;
        float y7 = ice7_postion.y;
        Vector3 ice8_postion = ice8.transform.position;
        float x8 = ice8_postion.x;
        float y8 = ice8_postion.y;
        Vector3 ice9_postion = ice9.transform.position;
        float x9 = ice9_postion.x;
        float y9 = ice9_postion.y;
        Vector3 ice10_postion = ice10.transform.position;
        float x10 = ice10_postion.x;
        float y10 = ice10_postion.y;
        Vector3 ice11_postion = ice11.transform.position;
        float x11 = ice11_postion.x;
        float y11 = ice11_postion.y;
        Vector3 ice12_postion = ice12.transform.position;
        float x12 = ice12_postion.x;
        float y12 = ice12_postion.y;
        Vector3 ice13_postion = ice13.transform.position;
        float x13 = ice13_postion.x;
        float y13 = ice13_postion.y;
        Vector3 ice14_postion = ice14.transform.position;
        float x14 = ice14_postion.x;
        float y14 = ice14_postion.y;
        Vector3 ice15_postion = ice15.transform.position;
        float x15 = ice15_postion.x;
        float y15 = ice15_postion.y;

        position(x1, y1,1);
        position(x2, y2,2);
        position(x3, y3,3);
        position(x4, y4,4);
        position(x5, y5, 5);
        position(x6, y6, 6);
        position(x7, y7, 7);
        position(x8, y8, 8);
        position(x9, y9, 9);
        position(x10, y10, 10);
        position(x11, y11, 11);
        position(x12, y12, 12);
        position(x13, y13, 13);
        position(x14, y14, 14);
        position(x15, y15, 15);


    }
    void position(float x, float y,int iceNum)
    {
        //get the position of each player box
        float x1 = player1.transform.position.x;
        float y1 = player1.transform.position.y;
        float x2 = player2.transform.position.x;
        float y2 = player2.transform.position.y;
        float x3 = player3.transform.position.x;
        float y3 = player3.transform.position.y;

        int place = 0;// remember which place the card stay in (0=table,1=player1.......)

        //get the position of ice cream card
        if (x > x1 - halfXsize && x < x1 + halfXsize)            //1
        {
            if (y > y1 - halfYsize && y < y1 + halfYsize)
            {
                placeChange1 = 1;//remember the change of each ice cream position
             
            }
        }
        if (x > x2 - halfXsize && x < x2 + halfXsize)             //2
        {
            if (y > y2 - halfYsize && y < y2 + halfYsize)
            {
                placeChange2 = 1;

            }
        }
        if (x > x3 - halfXsize && x < x3 + halfXsize)          //3
        {
            if (y > y3 - halfYsize && y < y3 + halfYsize)
            {
                placeChange3 = 1;
            }
        }

       // give the value to "place",with the signal of place change
        if (placeChange1 ==1)
        {
            place = 1;
        }
        if (placeChange2 == 1)
        {
            place = 2;
        }
        if (placeChange3 == 1)
        {
            place = 3;
        }
        //clear the change signal
        placeChange1 = 0;
        placeChange2 = 0;
        placeChange3 = 0;



        //give the situation information to the ice cream Data
        if (iceNum == 1)
        {
            icePlace1 = place;
        }
        if (iceNum == 2)
        {
            icePlace2 = place;
        }
        if (iceNum == 3)
        {
            icePlace3 = place;
        }
        if (iceNum == 4)
        {
            icePlace4 = place;
        }
        if (iceNum == 5)
        {
            icePlace5 = place;
        }
        if (iceNum == 6)
        {
            icePlace6 = place;
        }
        if (iceNum == 7)
        {
            icePlace7 = place;
        }
        if (iceNum == 8)
        {
            icePlace8 = place;
        }
        if (iceNum == 9)
        {
            icePlace9 = place;
        }
        if (iceNum == 10)
        {
            icePlace10 = place;
        }
        if (iceNum == 11)
        {
            icePlace11 = place;
        }
        if (iceNum == 12)
        {
            icePlace12 = place;
        }
        if (iceNum == 13)
        {
            icePlace13 = place;
        }
        if (iceNum == 14)
        {
            icePlace14 = place;
        }
        if (iceNum == 15)
        {
            icePlace15 = place;
        }

    }

    void totalscore()
    {


            if (icePlace1 == 1)
            {
                player1totalscore = player1totalscore + icecreamData.icecream1;
             
            }
            if (icePlace1 == 2)
            {
                player2totalscore = player2totalscore + icecreamData.icecream1;
      
            
            }
            if (icePlace1 == 3)
            {
                player3totalscore = player3totalscore + icecreamData.icecream1;
            
            }
        
        if (icePlace2 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream2;
        }
        if (icePlace2 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream2;
        }
        if (icePlace2 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream2;
        }
        if (icePlace3 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream3;
        }
        if (icePlace3 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream3;
        }
        if (icePlace3 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream3;
        }
        if (icePlace4 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream4;
        }
        if (icePlace4 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream4;
        }
        if (icePlace4 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream4;
        }
        if (icePlace5 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream5;
        }
        if (icePlace5 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream5;
        }
        if (icePlace5 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream5;
        }

        if (icePlace6 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream6;
        }
        if (icePlace6 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream6;
        }
        if (icePlace6 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream6;
        }

        if (icePlace7 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream7;
        }
        if (icePlace7 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream7;
        }
        if (icePlace7 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream7;
        }

        if (icePlace8 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream8;
        }
        if (icePlace8 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream8;
        }
        if (icePlace8 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream8;
        }

        if (icePlace9 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream9;
        }
        if (icePlace9 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream9;
        }
        if (icePlace9 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream9;
        }

        if (icePlace10 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream10;
        }
        if (icePlace10 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream10;
        }
        if (icePlace10 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream10;
        }
        if (icePlace11 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream11;
        }
        if (icePlace11 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream11;
        }
        if (icePlace11 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream11;
        }
        if (icePlace12 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream12;
        }
        if (icePlace12 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream12;
        }
        if (icePlace12 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream12;
        }
        if (icePlace13 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream13;
        }
        if (icePlace13 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream13;
        }
        if (icePlace13 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream13;
        }
        if (icePlace14 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream14;
        }
        if (icePlace14 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream14;
        }
        if (icePlace14 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream14;
        }
        if (icePlace15 == 1)
        {
            player1totalscore = player1totalscore + icecreamData.icecream15;
        }
        if (icePlace15 == 2)
        {
            player2totalscore = player2totalscore + icecreamData.icecream15;
        }
        if (icePlace15 == 3)
        {
            player3totalscore = player3totalscore + icecreamData.icecream15;
        }
    }
}
