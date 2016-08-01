using UnityEngine;
using System.Collections;

// at the fridge, if we click on the show score icon, then the icon will show in green which means the score of ice cream that has been selected will be shown,
//then if we don't want to show the score, we can click the icon again, and it will show in red, which means the score will not be shown.
public class ShowScore: MonoBehaviour
{
    public int open = 0;    // this variable judge whether the mouse is on the top of the icon of SeeFridge
    static public int showscore = 0;  /*a signal to know if we go to the Assign the score screen from the ice cream screen and so that we could reput to score 
                                       on the ingredient. if not, we just have the new define.*/
    private Color mouseOverColor = Color.blue;//  declare the variable value of blue
    private Color mouseclickyes = Color.green;
    private Color mouseclickno = Color.red;
    private Color originalColor;

    // Use this for initialization
    void Start()
    {

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
    void showscore1()   
    {
        if (Input.GetMouseButtonDown(0))    // if the mouse is clicked?
        {
            if (showscore == 0)
            {
                showscore = 1;
                GetComponent<Renderer>().material.color = mouseclickyes;
            }
            else if(showscore ==1)
            {
                showscore = 0;
                GetComponent<Renderer>().material.color = mouseclickno;
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (open == 1)
        {
            showscore1();


        }
    }
}