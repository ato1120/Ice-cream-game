using UnityEngine;
using System.Collections;

public class Remember : MonoBehaviour {

    //int turn=0;
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

    // the double card of the 15 kinds of card which is named with -of2
    GameObject ice1of2;
    GameObject ice2of2;
    GameObject ice3of2;
    GameObject ice4of2;
    GameObject ice5of2;
    GameObject ice6of2;
    GameObject ice7of2;
    GameObject ice8of2;
    GameObject ice9of2;
    GameObject ice10of2;
    GameObject ice11of2;
    GameObject ice12of2;
    GameObject ice13of2;

    // define the sign of the position of each ice cream of the player
    GameObject sign1;
    GameObject sign2;
    GameObject sign3;
    GameObject sign4;
    GameObject sign5;
    GameObject sign6;
    GameObject sign7;
    GameObject sign8;
    GameObject sign9;
    GameObject sign10;
    GameObject sign11;
    GameObject sign12;
    GameObject sign13;
    GameObject sign14;
    GameObject sign15;
    GameObject sign16;
    GameObject sign17;
    GameObject sign18;

    // to make sure which sign are now that should we put the ice cream card on,ex:from sign 1 to sign 6
    GameObject signal1;
    GameObject signal2;
    GameObject signal3;

    //obejct of the price card
    GameObject price1;//+30
    GameObject price2;
    GameObject price3;
    GameObject price4;
    GameObject price5;//-30
    GameObject price6;
    GameObject price7;
    GameObject price8;
    GameObject price9;//+10
    GameObject price10;
    GameObject price11;
    GameObject price12;
    GameObject price13;//-10
    GameObject price14;
    GameObject price15;
    GameObject price16;
    GameObject price17;//+20
    GameObject price18;
    GameObject price19;
    GameObject price20;
    GameObject price21;//-20
    GameObject price22;
    GameObject price23;
    GameObject price24;
    GameObject price25;//0
    GameObject price26;
    GameObject price27;
    GameObject price28;


    // signal of each place of ice cream of one player
    public int i1=0;
    public int i2=0;
    public int i3=0;

    //signal of give the same score to different ice cream in turn  
    public int s1 = 0;//+30
    public int s2 = 0;//-30
    public int s3 = 0;//+10
    public int s4 = 0;//-10
    public int s5 = 0;//+20
    public int s6 = 0;//-20
    public int s7 = 0;//0

    




    // Use this for initialization
    void Start () {



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

        ice1of2 = GameObject.Find("ice cream1-2");
        ice2of2 = GameObject.Find("ice cream2-2");
        ice3of2 = GameObject.Find("ice cream3-2");
        ice4of2 = GameObject.Find("ice cream4-2");
        ice5of2 = GameObject.Find("ice cream5-2");
        ice6of2 = GameObject.Find("ice cream6-2");
        ice7of2 = GameObject.Find("ice cream7-2");
        ice8of2 = GameObject.Find("ice cream8-2");
        ice9of2 = GameObject.Find("ice cream9-2");
        ice10of2 = GameObject.Find("ice cream10-2");
        ice11of2 = GameObject.Find("ice cream11-2");
        ice12of2 = GameObject.Find("ice cream12-2");
        ice13of2 = GameObject.Find("ice cream13-2");

        sign1 = GameObject.Find("sign");
        sign2 = GameObject.Find("sign (1)");
        sign3 = GameObject.Find("sign (2)");
        sign4 = GameObject.Find("sign (3)");
        sign5 = GameObject.Find("sign (4)");
        sign6 = GameObject.Find("sign (5)");
        sign7 = GameObject.Find("sign (6)");
        sign8 = GameObject.Find("sign (7)");
        sign9 = GameObject.Find("sign (8)");
        sign10 = GameObject.Find("sign (9)");
        sign11 = GameObject.Find("sign (10)");
        sign12 = GameObject.Find("sign (11)");
        sign13= GameObject.Find("sign (12)");
        sign14 = GameObject.Find("sign (13)");
        sign15= GameObject.Find("sign (14)");
        sign16 = GameObject.Find("sign (15)");
        sign17 = GameObject.Find("sign (16)");
        sign18 = GameObject.Find("sign (17)");

        // no show thw sign to player,it is just for give posotion to the ice cream card
        sign1.SetActive(false);
        sign2.SetActive(false);
        sign3.SetActive(false);
        sign4.SetActive(false);
        sign5.SetActive(false);
        sign6.SetActive(false);
        sign7.SetActive(false);
        sign8.SetActive(false);
        sign9.SetActive(false);
        sign10.SetActive(false);
        sign11.SetActive(false);
        sign12.SetActive(false);
        sign13.SetActive(false);
        sign14.SetActive(false);
        sign15.SetActive(false);
        sign16.SetActive(false);
        sign17.SetActive(false);
        sign18.SetActive(false);

        signal1 = GameObject.Find("signal1");
        signal2 = GameObject.Find("signal2");
        signal3 = GameObject.Find("signal3");

        signal1.SetActive(false);
        signal2.SetActive(false);
        signal3.SetActive(false);


        price1 = GameObject.Find("price+30(1)");
        price2 = GameObject.Find("price+30(2)");
        price3 = GameObject.Find("price+30(3)");
        price4 = GameObject.Find("price+30(4)");
        price5 = GameObject.Find("price-30(1)");
        price6 = GameObject.Find("price-30(2)");
        price7 = GameObject.Find("price-30(3)");
        price8 = GameObject.Find("price-30(4)");
        price9 = GameObject.Find("price+10(1)");
        price10 = GameObject.Find("price+10(2)");
        price11= GameObject.Find("price+10(3)");
        price12= GameObject.Find("price+10(4)");
        price13 = GameObject.Find("price-10(1)");
        price14 = GameObject.Find("price-10(2)");
        price15 = GameObject.Find("price-10(3)");
        price16 = GameObject.Find("price-10(4)");

        price17 = GameObject.Find("price+20(1)");
        price18 = GameObject.Find("price+20(2)");
        price19 = GameObject.Find("price+20(3)");
        price20 = GameObject.Find("price+20(4)");

        price21 = GameObject.Find("price-20(1)");
        price22 = GameObject.Find("price-20(2)");
        price23 = GameObject.Find("price-20(3)");
        price24 = GameObject.Find("price-20(4)");

        price25 = GameObject.Find("price0(1)");
        price26 = GameObject.Find("price0(2)");
        price27 = GameObject.Find("price0(3)");
        price28 = GameObject.Find("price0(4)");



        reput();



    }
	
	// Update is called once per frame
	void Update () {
        
	}


    // when come back from the fridge, we reput the ice cream they have chosen to the player box
    void reput()
    {
        if (GoBack.goBack == 1)  // if we come back from the fridge
        {
            if (playerData.icePlace1 == 1)  //if ice cream 1 were at the selected box of player 1
            {
                putsignal1();
                ice1.transform.position = signal1.transform.position; //put the ice cream 1 to the place of where the signal of player 1 is
                score(icecreamData.icecream1, ice1);

            }


            if (playerData.icePlace1 == 2)
            {
                putsignal2();
                ice1.transform.position = signal2.transform.position;
                score(icecreamData.icecream1, ice1);

            }
            if (playerData.icePlace1 == 3)
            {
                putsignal3();
                ice1.transform.position = signal3.transform.position;
                score(icecreamData.icecream1, ice1);
            }

            if (playerData.icePlace2 == 1)
            {
                putsignal1();
                ice2.transform.position = signal1.transform.position;
                score(icecreamData.icecream2, ice2);
            }
            if (playerData.icePlace2 == 2)
            {
                putsignal2();
                ice2.transform.position = signal2.transform.position;
                score(icecreamData.icecream2, ice2);
            }
            if (playerData.icePlace2 == 3)
            {
                putsignal3();
                ice2.transform.position = signal3.transform.position;
                score(icecreamData.icecream2, ice2);
            }
            if (playerData.icePlace3 == 1)
            {
                putsignal1();
                ice3.transform.position = signal1.transform.position;
                score(icecreamData.icecream3, ice3);
            }
            if (playerData.icePlace3 == 2)
            {
                putsignal2();
                ice3.transform.position = signal2.transform.position;
                score(icecreamData.icecream3, ice3);
            }
            if (playerData.icePlace3 == 3)
            {
                putsignal3();
                ice3.transform.position = signal3.transform.position;
                score(icecreamData.icecream3, ice3);
            }
            if (playerData.icePlace4 == 1)
            {
                putsignal1();
                ice4.transform.position = signal1.transform.position;
                score(icecreamData.icecream4, ice4);
            }
            if (playerData.icePlace4 == 2)
            {
                putsignal2();
                ice4.transform.position = signal2.transform.position;
                score(icecreamData.icecream4, ice4);
            }
            if (playerData.icePlace4 == 3)
            {
                putsignal3();
                ice4.transform.position = signal3.transform.position;
                score(icecreamData.icecream4, ice4);
            }
            if (playerData.icePlace5 == 1)
            {
                putsignal1();
                ice5.transform.position = signal1.transform.position;
                score(icecreamData.icecream5, ice5);
            }
            if (playerData.icePlace5 == 2)
            {
                putsignal2();
                ice5.transform.position = signal2.transform.position;
                score(icecreamData.icecream5, ice5);
            }
            if (playerData.icePlace5 == 3)
            {
                putsignal3();
                ice5.transform.position = signal3.transform.position;
                score(icecreamData.icecream5, ice5);
            }

            if (playerData.icePlace6 == 1)
            {
                putsignal1();
                ice6.transform.position = signal1.transform.position;
                score(icecreamData.icecream6, ice6);
            }
            if (playerData.icePlace6 == 2)
            {
                putsignal2();
                ice6.transform.position = signal2.transform.position;
                score(icecreamData.icecream6, ice6);
            }
            if (playerData.icePlace6 == 3)
            {
                putsignal3();
                ice6.transform.position = signal3.transform.position;
                score(icecreamData.icecream6, ice6);
            }

            if (playerData.icePlace7 == 1)
            {
                putsignal1();
                ice7.transform.position = signal1.transform.position;
                score(icecreamData.icecream7, ice7);
            }
            if (playerData.icePlace7 == 2)
            {
                putsignal2();
                ice7.transform.position = signal2.transform.position;
                score(icecreamData.icecream7, ice7);
            }
            if (playerData.icePlace7 == 3)
            {
                putsignal3();
                ice7.transform.position = signal3.transform.position;
                score(icecreamData.icecream7, ice7);
            }

            if (playerData.icePlace8 == 1)
            {
                putsignal1();
                ice8.transform.position = signal1.transform.position;
                score(icecreamData.icecream8, ice8);
            }
            if (playerData.icePlace8 == 2)
            {
                putsignal2();
                ice8.transform.position = signal2.transform.position;
                score(icecreamData.icecream8, ice8);
            }
            if (playerData.icePlace8 == 3)
            {
                putsignal3();
                ice8.transform.position = signal3.transform.position;
                score(icecreamData.icecream8, ice8);
            }

            if (playerData.icePlace9 == 1)
            {
                putsignal1();
                ice9.transform.position = signal1.transform.position;
                score(icecreamData.icecream9, ice9);
            }
            if (playerData.icePlace9 == 2)
            {
                putsignal2();
                ice9.transform.position = signal2.transform.position;
                score(icecreamData.icecream9, ice9);
            }
            if (playerData.icePlace9 == 3)
            {
                putsignal3();
                ice9.transform.position = signal3.transform.position;
                score(icecreamData.icecream9, ice9);
            }

            if (playerData.icePlace10 == 1)
            {
                putsignal1();
                ice10.transform.position = signal1.transform.position;
                score(icecreamData.icecream10, ice10);
            }
            if (playerData.icePlace10 == 2)
            {
                putsignal2();
                ice10.transform.position = signal2.transform.position;
                score(icecreamData.icecream10, ice10);
            }
            if (playerData.icePlace10 == 3)
            {
                putsignal3();
                ice10.transform.position = signal3.transform.position;
                score(icecreamData.icecream10, ice10);
            }
            if (playerData.icePlace11 == 1)
            {
                putsignal1();
                ice11.transform.position = signal1.transform.position;
                score(icecreamData.icecream11, ice11);
            }
            if (playerData.icePlace11 == 2)
            {
                putsignal2();
                ice11.transform.position = signal2.transform.position;
                score(icecreamData.icecream11, ice11);
            }
            if (playerData.icePlace11 == 3)
            {
                putsignal3();
                ice11.transform.position = signal3.transform.position;
                score(icecreamData.icecream11, ice11);
            }
            if (playerData.icePlace12 == 1)
            {
                putsignal1();
                ice12.transform.position = signal1.transform.position;
                score(icecreamData.icecream12, ice12);
            }
            if (playerData.icePlace12 == 2)
            {
                putsignal2();
                ice12.transform.position = signal2.transform.position;
                score(icecreamData.icecream12, ice12);
            }
            if (playerData.icePlace12 == 3)
            {
                putsignal3();
                ice12.transform.position = signal3.transform.position;
                score(icecreamData.icecream12, ice12);
            }
            if (playerData.icePlace13 == 1)
            {
                putsignal1();
                ice13.transform.position = signal1.transform.position;
                score(icecreamData.icecream13, ice13);
            }
            if (playerData.icePlace13 == 2)
            {
                putsignal2();
                ice13.transform.position = signal2.transform.position;
                score(icecreamData.icecream13, ice13);
            }
            if (playerData.icePlace13 == 3)
            {
                putsignal3();
                ice13.transform.position = signal3.transform.position;
                score(icecreamData.icecream13, ice13);
            }
            if (playerData.icePlace14 == 1)
            {
                putsignal1();
                ice14.transform.position = signal1.transform.position;
                score(icecreamData.icecream14, ice14);
            }
            if (playerData.icePlace14 == 2)
            {
                putsignal2();
                ice14.transform.position = signal2.transform.position;
                score(icecreamData.icecream14, ice14);
            }
            if (playerData.icePlace14 == 3)
            {
                putsignal3();
                ice14.transform.position = signal3.transform.position;
                score(icecreamData.icecream14, ice14);
            }
            if (playerData.icePlace15 == 1)
            {
                putsignal1();
                ice15.transform.position = signal1.transform.position;
                score(icecreamData.icecream15, ice15);
            }
            if (playerData.icePlace15 == 2)
            {
                putsignal2();
                ice15.transform.position = signal2.transform.position;
                score(icecreamData.icecream15, ice15);
            }
            if (playerData.icePlace15 == 3)
            {
                putsignal3();
                ice15.transform.position = signal3.transform.position;
                score(icecreamData.icecream15, ice15);
            }



            if (playerData.icePlace1of2 == 1)
            {
                putsignal1();
                ice1of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream1of2, ice1of2);
            }
            if (playerData.icePlace1of2 == 2)
            {
                putsignal2();
                ice1of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream1of2, ice1of2);

            }
            if (playerData.icePlace1of2 == 3)
            {
                putsignal3();
                ice1of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream1of2, ice1of2);
            }

            if (playerData.icePlace2of2 == 1)
            {
                putsignal1();
                ice2of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream2of2, ice2of2);
            }
            if (playerData.icePlace2of2 == 2)
            {
                putsignal2();
                ice2of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream2of2, ice2of2);
            }
            if (playerData.icePlace2of2 == 3)
            {
                putsignal3();
                ice2of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream2of2, ice2of2);
            }
            if (playerData.icePlace3of2 == 1)
            {
                putsignal1();
                ice3of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream3of2, ice3of2);
            }
            if (playerData.icePlace3of2 == 2)
            {
                putsignal2();
                ice3of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream3of2, ice3of2);
            }
            if (playerData.icePlace3of2 == 3)
            {
                putsignal3();
                ice3of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream3of2, ice3of2);
            }
            if (playerData.icePlace4of2 == 1)
            {
                putsignal1();
                ice4of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream4of2, ice4of2);
            }
            if (playerData.icePlace4of2 == 2)
            {
                putsignal2();
                ice4of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream4of2, ice4of2);
            }
            if (playerData.icePlace4of2 == 3)
            {
                putsignal3();
                ice4of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream4of2, ice4of2);
            }
            if (playerData.icePlace5of2 == 1)
            {
                putsignal1();
                ice5of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream5of2, ice5of2);
            }
            if (playerData.icePlace5of2 == 2)
            {
                putsignal2();
                ice5of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream5of2, ice5of2);
            }
            if (playerData.icePlace5of2 == 3)
            {
                putsignal3();
                ice5of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream5of2, ice5of2);
            }

            if (playerData.icePlace6of2 == 1)
            {
                putsignal1();
                ice6of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream6of2, ice6of2);
            }
            if (playerData.icePlace6of2 == 2)
            {
                putsignal2();
                ice6of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream6of2, ice6of2);
            }
            if (playerData.icePlace6of2 == 3)
            {
                putsignal3();
                ice6of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream6of2, ice6of2);
            }

            if (playerData.icePlace7of2 == 1)
            {
                putsignal1();
                ice7of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream7of2, ice7of2);
            }
            if (playerData.icePlace7of2 == 2)
            {
                putsignal2();
                ice7of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream7of2, ice7of2);
            }
            if (playerData.icePlace7of2 == 3)
            {
                putsignal3();
                ice7of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream7of2, ice7of2);
            }

            if (playerData.icePlace8of2 == 1)
            {
                putsignal1();
                ice8of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream8of2, ice8of2);
            }
            if (playerData.icePlace8of2 == 2)
            {
                putsignal2();
                ice8of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream8of2, ice8of2);

            }
            if (playerData.icePlace8of2 == 3)
            {
                putsignal3();
                ice8of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream8of2, ice8of2);
            }

            if (playerData.icePlace9of2 == 1)
            {
                putsignal1();
                ice9of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream9of2, ice9of2);
            }
            if (playerData.icePlace9of2 == 2)
            {
                putsignal2();
                ice9of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream9of2, ice9of2);
            }
            if (playerData.icePlace9of2 == 3)
            {
                putsignal3();
                ice9of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream9of2, ice9of2);
            }

            if (playerData.icePlace10of2 == 1)
            {
                putsignal1();
                ice10of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream10of2, ice10of2);
            }
            if (playerData.icePlace10of2 == 2)
            {
                putsignal2();
                ice10of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream10of2, ice10of2);
            }
            if (playerData.icePlace10of2 == 3)
            {
                putsignal3();
                ice10of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream10of2, ice10of2);
            }
            if (playerData.icePlace11of2 == 1)
            {
                putsignal1();
                ice11of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream11of2, ice11of2);
            }
            if (playerData.icePlace11of2 == 2)
            {
                putsignal2();
                ice11of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream11of2, ice11of2);
            }
            if (playerData.icePlace11of2 == 3)
            {
                putsignal3();
                ice11of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream11of2, ice11of2);
            }
            if (playerData.icePlace12of2 == 1)
            {
                putsignal1();
                ice12of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream12of2, ice12of2);
            }
            if (playerData.icePlace12of2 == 2)
            {
                putsignal2();
                ice12of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream12of2, ice12of2);
            }
            if (playerData.icePlace12of2 == 3)
            {
                putsignal3();
                ice12of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream12of2, ice12of2);
            }
            if (playerData.icePlace13of2 == 1)
            {
                putsignal1();
                ice13of2.transform.position = signal1.transform.position;
                score(icecreamData.icecream13of2, ice13of2);
            }
            if (playerData.icePlace13of2 == 2)
            {
                putsignal2();
                ice13of2.transform.position = signal2.transform.position;
                score(icecreamData.icecream13of2, ice13of2);
            }
            if (playerData.icePlace13of2 == 3)
            {
                putsignal3();
                ice13of2.transform.position = signal3.transform.position;
                score(icecreamData.icecream13of2, ice13of2);
            }
        }
    }

    // put the signal of each player in turn
    void putsignal1()
    {
        if (i1 == 0)
        {
            signal1.transform.position = sign1.transform.position;
        }
        if (i1 == 1)
        {
            signal1.transform.position = sign2.transform.position;
        }
        if (i1 == 2)
        {
            signal1.transform.position = sign3.transform.position;
        }
        if (i1 == 3)
        {
            signal1.transform.position = sign4.transform.position;
        }
        if (i1 == 4)
        {
            signal1.transform.position = sign5.transform.position;
        }
        if (i1 == 5)
        {
            signal1.transform.position = sign6.transform.position;
        }

        if(i1==5)
        {
            i1 = 0;
        }
        i1++;
    }

    void putsignal2()
    {
        if (i2 == 0)
        {
            signal2.transform.position = sign7.transform.position;
        }
        if (i2 == 1)
        {
            signal2.transform.position = sign8.transform.position;
        }
        if (i2 == 2)
        {
            signal2.transform.position = sign9.transform.position;
        }
        if (i2 == 3)
        {
            signal2.transform.position = sign10.transform.position;
        }
        if (i2 == 4)
        {
            signal2.transform.position = sign11.transform.position;
        }
        if (i2 == 5)
        {
            signal2.transform.position = sign12.transform.position;
        }

        if(i2==5)
        {
            i2 = 0;
        }
        i2++;
    }

    void putsignal3()
    {
        if (i3 == 0)
        {
            signal3.transform.position = sign13.transform.position;
        }
        if (i3 == 1)
        {
            signal3.transform.position = sign14.transform.position;
        }
        if (i3 == 2)
        {
            signal3.transform.position = sign15.transform.position;
        }
        if (i3 == 3)
        {
            signal3.transform.position = sign16.transform.position;
        }
        if (i3 == 4)
        {
            signal3.transform.position = sign17.transform.position;
        }
        if (i3 == 5)
        {
            signal3.transform.position = sign18.transform.position;
        }

        if(i3==5)
        {
            i3 = 0;
        }
        i3++;
    }

    //call for the giveprice function the give the score to the ice cream
    void  score(int icecreamscore,GameObject icecream)
    {
       
            if (icecreamscore == 30)
            {
                giveprice(price1, price2, price3, price4, icecream, s1); 
                if (s1 == 3)//change a different price card
                {
                    s1 = 0;
                }
                s1++;
            }
            if (icecreamscore == -30)
            {
                giveprice(price5, price6, price7, price8, icecream, s2);
                if (s2 == 3)
                {
                    s2 = 0;
                }
                s2++;
            }
            if (icecreamscore == 10)
            {
                giveprice(price9, price10, price11, price12, icecream, s3);
                if (s3 == 3)
                {
                    s3 = 0;
                }
                s3++;
            }
            if (icecreamscore == -10)
            {
                giveprice(price13, price14, price15, price16, icecream, s4);
                if (s4 == 3)
                {
                    s4 = 0;
                }
                s4++;
            }
            if (icecreamscore == 20)
            {
                giveprice(price17, price18, price19, price20, icecream, s5);
                if (s5 == 3)
                {
                    s5 = 0;
                }
                s5++;
            }
            if (icecreamscore == -20)
            {
                giveprice(price21, price22, price23, price24, icecream, s6);
                if (s6 == 3)
                {
                    s6 = 0;
                }
                s6++;
            }
            if (icecreamscore == 0)
            {
                giveprice(price25, price26, price27, price28, icecream, s7);
                if (s7 == 3)
                {
                    s7 = 0;
                }
                s7++;
            }
        

    }

    // put the score on the ice cream card that has been selected
    void giveprice(GameObject obj1,GameObject obj2,GameObject obj3,GameObject obj4, GameObject icecream,int score)
    {
        if (ShowScore.showscore == 1)
        {
            if (score == 0)
            {
                obj1.transform.position = icecream.transform.position;

            }
            if (score == 1)
            {
                obj2.transform.position = icecream.transform.position;
            }
            if (score == 2)
            {
                obj3.transform.position = icecream.transform.position;
            }
            if (score == 3)
            {
                obj4.transform.position = icecream.transform.position;
            }
        }
    }
}
