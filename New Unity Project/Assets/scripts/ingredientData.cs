using UnityEngine;
using System.Collections;

public class ingredientData : MonoBehaviour {
    //define the object of each price card
    GameObject m_obj1;
    GameObject m_obj2;
    GameObject m_obj3;
    GameObject m_obj4;
    int chocolateSauce = 0;
    int raspberrySauce = 0;
    int waferTopping = 0;
    int cherryTopping = 0;
    int plainCone = 0;
    int sprinkleCone = 0;
    int vanillaFlavor = 0;
    int strawberryFlavor = 0;
    // Use this for initialization

    //get the position of each price card
    public void Start () {
       //get the position of each price card
        m_obj1 = GameObject.Find("price (1)");
        m_obj2 = GameObject.Find("price (2)");
        m_obj3 = GameObject.Find("price (3)");
        m_obj4 = GameObject.Find("price (4)");

       //Vector3 price1_postion = m_obj1.transform.position;
       // float x1 = price1_postion.x;
       // float y1 = price1_postion.y;
        Vector3 price2_postion = m_obj2.transform.position;
        float x2 = price2_postion.x;
        float y2 = price2_postion.y;
        Vector3 price3_postion = m_obj3.transform.position;
        float x3 = price3_postion.x;
        float y3 = price3_postion.y;
        Vector3 price4_postion = m_obj4.transform.position;
        float x4 = price4_postion.x;
        float y4 = price4_postion.y;
        
   /*     //Give the score +20 to an ingredient 
        if (x1 > 7.17 && x1 < 9.76)            //1
        {
                if (y1 > 5.15 && y1 < 8.83)
                {
                    strawberryFlavor = 20;
                }
        }
        if (x1 > 3.31 && x1 < 5.86)             //2
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                raspberrySauce = 20;          
            }
        }
        if (x1 > -0.41 && x1 < 2.26)          //3
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                vanillaFlavor = 20;
            }
        }
        if (x1 > -4.18 && x1 < -1.76)         //4
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                waferTopping = 20;
            }
        }
        if (x1 > 7.17 && x1 < 9.76)           //5
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }
        if (x1 > 3.31 && x1 < 5.86)            //6
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }
        if (x1 > -0.41 && x1 < 2.26)            //7
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }
        if (x1 > -4.18 && x1 < -1.76)            //8
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }

        Debug.Log(chocolateSauce.ToString("f4"));  */
    }

	// Update is called once per frame
	void Update () {
        Vector3 price1_postion = m_obj1.transform.position;
        float x1 = price1_postion.x;
        float y1 = price1_postion.y;
        //Give the score +20 to an ingredient 
        if (x1 > 7.17 && x1 < 9.76)            //1
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                strawberryFlavor = 20;
            }
        }
        if (x1 > 3.31 && x1 < 5.86)             //2
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                raspberrySauce = 20;
            }
        }
        if (x1 > -0.41 && x1 < 2.26)          //3
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                vanillaFlavor = 20;
            }
        }
        if (x1 > -4.18 && x1 < -1.76)         //4
        {
            if (y1 > 5.15 && y1 < 8.83)
            {
                waferTopping = 20;
            }
        }
        if (x1 > 7.17 && x1 < 9.76)           //5
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }
        if (x1 > 3.31 && x1 < 5.86)            //6
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }
        if (x1 > -0.41 && x1 < 2.26)            //7
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }
        if (x1 > -4.18 && x1 < -1.76)            //8
        {
            if (y1 > 0.10 && y1 < 3.78)
            {
                chocolateSauce = 20;
            }
        }

        Debug.Log(chocolateSauce.ToString("f4"));

    }
}
