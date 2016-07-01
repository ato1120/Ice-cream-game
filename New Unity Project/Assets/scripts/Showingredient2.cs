using UnityEngine;
using System.Collections;

public class Showingredient2 : MonoBehaviour {
    GameObject m_obj1;
    GameObject m_obj2;
    GameObject m_obj3;
    GameObject m_obj4;
    GameObject m_obj5;
    GameObject m_obj6;
    GameObject m_obj7;
    GameObject m_obj8;
   public int i=1;
   public int open = 0;
    private Color mouseOverColor = Color.blue;//声明变量为蓝色   declare the variable value of white
    private Color mouseAwayColor = Color.black;//declare the variable value of black
    private Color originalColor;

    // Use this for initialization
    void Start () {
        m_obj1 = GameObject.Find("ingredient1");
        m_obj1.SetActive(false);
        m_obj2 = GameObject.Find("ingredient2");
        m_obj2.SetActive(false);
        m_obj3 = GameObject.Find("ingredient3");
        m_obj3.SetActive(false);
        m_obj4 = GameObject.Find("ingredient4");
        m_obj4.SetActive(false);
        m_obj5 = GameObject.Find("ingredient5");
        m_obj5.SetActive(false);
        m_obj6 = GameObject.Find("ingredient6");
        m_obj6.SetActive(false);
        m_obj7 = GameObject.Find("ingredient7");
        m_obj7.SetActive(false);
        m_obj8 = GameObject.Find("ingredient8");
        m_obj8.SetActive(false);

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
	void ShowEachIngredient()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log( "Show new ingredient" );
            if (i == 1)
            {
                m_obj1.SetActive(true);
    
            }
            if (i == 2)
            {
                m_obj2.SetActive(true);

            }
            if (i == 3)
            {
                m_obj3.SetActive(true);

            }
            if (i == 4)
            {
                m_obj4.SetActive(true);

            }
            if (i == 5)
            {
                m_obj5.SetActive(true);
            }
            if (i == 6)
            {
                m_obj6.SetActive(true);
            }
            if (i == 7)
            {
                m_obj7.SetActive(true);
            }
            if (i == 8)
            {
                m_obj8.SetActive(true);
            }

            i++;


        }
    }
	// Update is called once per frame
	void Update ()
    {

        //OnMouseEnter();
        //OnMouseExit();
        if (open == 1)
        {
            ShowEachIngredient();

        }
	}
}
