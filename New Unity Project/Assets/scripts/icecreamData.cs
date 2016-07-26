using UnityEngine;
using System.Collections;

public class icecreamData : MonoBehaviour {


    //define the score of each ice cream
       /*
       icecream1 = cherryTopping+plainCone+vanillaFlavor+raspberrySauce;
       icecream2 = cherryTopping + plainCone + vanillaFlavor + chocolateSauce;
       icecream3 = cherryTopping + sprinkleCone + vanillaFlavor + chocolateSauce;
       icecream4 = cherryTopping + plainCone + strawberryFlavor + raspberrySauce;
       icecream5= cherryTopping + plainCone + strawberryFlavor + chocolateSauce;
       icecream6= cherryTopping +sprinkleCone + strawberryFlavor + chocolateSauce;
       icecream7= cherryTopping + sprinkleCone + strawberryFlavor + raspberrySauce;
       icecream8= waferTopping + plainCone + vanillaFlavor + raspberrySauce;
       icecream9= waferTopping + sprinkleCone + vanillaFlavor + raspberrySauce;
       icecream10 =waferTopping +plainCone +vanillaFlavor +chocolateSauce;
       icecream11= waferTopping +sprinkleCone + vanillaFlavor + chocolateSauce;
       icecream12 = waferTopping + plainCone +strawberryFlavor + chocolateSauce;
       icecream13= waferTopping +sprinkleCone +strawberryFlavor +chocolateSauce;
       icecream14 =waferTopping +plainCone +strawberryFlavor +raspberrySauce;
       icecream15= waferTopping +sprinkleCone + strawberryFlavor +raspberrySauce;
       */
    static public int icecream1 = 0;
    static public int icecream2 = 0;
    static public int icecream3 = 0;
    static public int icecream4 = 0;
    static public int icecream5 = 0;
    static public int icecream6 = 0;
    static public int icecream7 = 0;
    static public int icecream8 = 0;
    static public int icecream9 = 0;
    static public int icecream10 = 0;
    static public int icecream11 = 0;
    static public int icecream12 = 0;
    static public int icecream13 = 0;
    static public int icecream14 = 0;
    static public int icecream15 = 0;

    // the double card of the 15 kinds of card which is named with -of2
    static public int icecream1of2 = 0;
    static public int icecream2of2 = 0;
    static public int icecream3of2 = 0;
    static public int icecream4of2 = 0;
    static public int icecream5of2 = 0;
    static public int icecream6of2 = 0;
    static public int icecream7of2 = 0;
    static public int icecream8of2 = 0;
    static public int icecream9of2 = 0;
    static public int icecream10of2 = 0;
    static public int icecream11of2 = 0;
    static public int icecream12of2 = 0;
    static public int icecream13of2 = 0;
    static public int icecream14of2 = 0;
    static public int icecream15of2 = 0;

    //define and intitial the score of each ingredient
    static public int chocolateSauce = 0;
    static public int raspberrySauce = 0;
    static public int waferTopping = 0;
    static public int cherryTopping = 0;
    static public int plainCone = 0;
    static public int sprinkleCone = 0;
    static public int vanillaFlavor = 0;
    static public int strawberryFlavor = 0;

    // Use this for initialization
    void Start () {
        

        icecream1 = ingredientData.cherryTopping+ingredientData.plainCone+ingredientData.vanillaFlavor+ingredientData.raspberrySauce;
        icecream2 = ingredientData.cherryTopping + ingredientData.plainCone + ingredientData.vanillaFlavor + ingredientData.chocolateSauce;
        icecream3 = ingredientData.cherryTopping + ingredientData.sprinkleCone + ingredientData.vanillaFlavor + ingredientData.chocolateSauce;
        icecream4 = ingredientData.cherryTopping + ingredientData.plainCone + ingredientData.strawberryFlavor + ingredientData.raspberrySauce;
        icecream5= ingredientData.cherryTopping + ingredientData.plainCone + ingredientData.strawberryFlavor + ingredientData.chocolateSauce;
        icecream6= ingredientData.cherryTopping + ingredientData.sprinkleCone + ingredientData.strawberryFlavor + ingredientData.chocolateSauce;
        icecream7= ingredientData.cherryTopping + ingredientData.sprinkleCone + ingredientData.strawberryFlavor + ingredientData.raspberrySauce;
        icecream8= ingredientData.waferTopping + ingredientData.plainCone + ingredientData.vanillaFlavor + ingredientData.raspberrySauce;
        icecream9= ingredientData.waferTopping + ingredientData.sprinkleCone + ingredientData.vanillaFlavor + ingredientData.raspberrySauce;
        icecream10 = ingredientData.waferTopping + ingredientData.plainCone + ingredientData.vanillaFlavor + ingredientData.chocolateSauce;
        icecream11= ingredientData.waferTopping + ingredientData.sprinkleCone + ingredientData.vanillaFlavor + ingredientData.chocolateSauce;
        icecream12 = ingredientData.waferTopping + ingredientData.plainCone + ingredientData.strawberryFlavor + ingredientData.chocolateSauce;
        icecream13= ingredientData.waferTopping + ingredientData.sprinkleCone + ingredientData.strawberryFlavor + ingredientData.chocolateSauce;
        icecream14 = ingredientData.waferTopping + ingredientData.plainCone + ingredientData.strawberryFlavor + ingredientData.raspberrySauce;
        icecream15= ingredientData.waferTopping + ingredientData.sprinkleCone + ingredientData.strawberryFlavor + ingredientData.raspberrySauce;

        icecream1of2 = icecream1;
        icecream2of2 = icecream2;
        icecream3of2 = icecream3;
        icecream4of2 = icecream4;
        icecream5of2 = icecream5;
        icecream6of2 = icecream6;
        icecream7of2 = icecream7;
        icecream8of2 = icecream8;
        icecream9of2 = icecream9;
        icecream10of2 = icecream10;
        icecream11of2 = icecream11;
        icecream12of2 = icecream12;
        icecream13of2 = icecream13;
        icecream14of2 = icecream14;
        icecream15of2 = icecream15;


    }
	
	// Update is called once per frame
	void Update () {

      /* print("icecream1="+icecream1.ToString("f4") +"  icecream2="+ icecream2.ToString("f4") + "  icecream3="+icecream3.ToString("f4")
           +"  icecream4= "+icecream4.ToString("f4")+"  icecream5="+icecream5.ToString("f4"));// this can show the score of each ice cream on the bottom of the screen
      */

        rememberData();

}

    //to remember the data of each ingredient score and reput them on their palces
    //This data is saved for the reput function in the ingredientData script
    void rememberData()
    {
        cherryTopping = ingredientData.cherryTopping;
        chocolateSauce = ingredientData.chocolateSauce;
        raspberrySauce = ingredientData.raspberrySauce;
        waferTopping = ingredientData.waferTopping;
        plainCone = ingredientData.plainCone;
        sprinkleCone = ingredientData.sprinkleCone;
        vanillaFlavor = ingredientData.vanillaFlavor;
        strawberryFlavor = ingredientData.strawberryFlavor;
    }
}
