using UnityEngine;
using System.Collections;

public class icecreamData : MonoBehaviour {


    //define the score of each ice cream
    public int icecream1 = 0;
    public int icecream2 = 0;
    public int icecream3 = 0;
    public int icecream4 = 0;
    public int icecream5 = 0;
    public int icecream6 = 0;
    public int icecream7 = 0;
    public int icecream8 = 0;
    public int icecream9 = 0;
    public int icecream10 = 0;
    public int icecream11 = 0;
    public int icecream12 = 0;
    public int icecream13 = 0;
    public int icecream14 = 0;
    public int icecream15 = 0;

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

    }
	
	// Update is called once per frame
	void Update () {

       print("icecream1="+icecream1.ToString("f4") +"  icecream2="+ icecream2.ToString("f4") + "  icecream3="+icecream3.ToString("f4")
           +"  icecream4= "+icecream4.ToString("f4")+"  icecream5="+icecream5.ToString("f4"));

        rememberData();

}

    //to remember the data of each ingredient score and reput them on their palces
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
