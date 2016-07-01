using UnityEngine;
using System.Collections;

public class GoBack : MonoBehaviour {

    public int open = 0;
    private Color mouseOverColor = Color.blue;//声明变量为蓝色   declare the variable value of white
    private Color originalColor;

    // Use this for initialization
    void Start()
    {

        originalColor = GetComponent<Renderer>().sharedMaterial.color;//开始时得到物体着色 get the original color of the object at the beginning  

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
