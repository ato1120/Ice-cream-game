using UnityEngine;
using System.Collections;

public class GoBack : MonoBehaviour {

    public int open = 0;// this variable judge whether the mouse is on the top of the icon of Go back to the desktop
    private Color mouseOverColor = Color.blue;//   declare the variable value of white
    private Color originalColor;

    static public int goBack=0;


    // Use this for initialization
    void Start()
    {

        originalColor = GetComponent<Renderer>().sharedMaterial.color;// get the original color of the object at the beginning  

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
    void SeeFridge1()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("ice cream");
            //Application.LoadLevelAdditive("ice cream");
            goBack = 1;
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
