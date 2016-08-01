using UnityEngine;
using System.Collections;

public class SeeFridge : MonoBehaviour
{
    public int open = 0;    // this variable judge whether the mouse is on the top of the icon of SeeFridge
    static public int seefridge = 0;  /*a signal to know if we go to the Assign the score screen from the ice cream screen and so that we could reput to score 
                                       on the ingredient. if not, we just have the new define.*/
    private Color mouseOverColor = Color.blue;//  declare the variable value of white
    private Color originalColor;

    // Use this for initialization
    void Start()    {

     originalColor = GetComponent<Renderer>().sharedMaterial.color;//get the original color of the object at the beginning  

    
    }
    void OnMouseEnter()
    {
        open = 1;
        GetComponent<Renderer>().material.color = mouseOverColor;
    }
    void OnMouseExit()
    {
        open = 0;
        GetComponent<Renderer>().material.color = originalColor;
    }
    void SeeFridge1()   // implement the link from ice cream screen to Assign the score screen
    {
        if (Input.GetMouseButtonDown(0))    // if the mouse is clicked?
        {
            Application.LoadLevel("Assign the score(fridge)");    //Jump now!
            

            seefridge = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (open == 1)
        {
            SeeFridge1();
            

        }
    }
}