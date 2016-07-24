using UnityEngine;
using System.Collections;

public class Showingredient3 : MonoBehaviour
{
    GameObject m_obj1;
    GameObject m_obj2;
    GameObject m_obj3;
    GameObject m_obj4;
    GameObject m_obj5;
    GameObject m_obj6;
    GameObject m_obj7;
    GameObject m_obj8;

    GameObject newone4;
    GameObject newone1;
    GameObject newone2;
    GameObject newone3;


    public int i = 0;
    public int open = 0;
    private Color mouseOverColor = Color.blue;//声明变量为蓝色   declare the variable value of white
    private Color mouseAwayColor = Color.black;//declare the variable value of black
    private Color originalColor;


    // Use this for initialization
    void Start()
    {
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

        newone4 = GameObject.Find("new4");
        newone1 = GameObject.Find("new1");
        newone2 = GameObject.Find("new2");
        newone3 = GameObject.Find("new3");

        newone4.SetActive(false);
        newone1.SetActive(false);
        newone2.SetActive(false);
        newone3.SetActive(false);

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
            

            m_obj1.SetActive(false );    //reset the ingredient
            m_obj2.SetActive(false);
            m_obj3.SetActive(false);
            m_obj4.SetActive(false);
            m_obj5.SetActive(false);
            m_obj6.SetActive(false);
            m_obj7.SetActive(false);
            m_obj8.SetActive(false);

            newone4.SetActive(false);
            newone1.SetActive(false);
            newone2.SetActive(false);
            newone3.SetActive(false);

            int random = 0;               //produce a random number
            random = Random.Range(0, 8);

          
            Debug.Log("Show new ingredient");
            if (random>=0 && random <1)
            {
                m_obj1.SetActive(true);

            }
            if (random >= 1 && random < 2)
            {
                m_obj2.SetActive(true);

            }
            if (random >= 2 && random < 3)
            {
                m_obj3.SetActive(true);

            }
            if (random >= 3 && random < 4)
            {
                m_obj4.SetActive(true);

            }
            if (random >= 4 && random < 5)
            {
                m_obj5.SetActive(true);
            }
            if (random >= 5 && random < 6)
            {
                m_obj6.SetActive(true);
            }
            if (random >= 6 && random < 7)
            {
                m_obj7.SetActive(true);
            }
            if (random >= 7 && random < 8)
            {
                m_obj8.SetActive(true);
            }


            if(i==0)
            {
                newone1.SetActive(true ); 
            }

            if (i == 1)
            {
                newone2.SetActive(true);
            }
            if (i == 2)
            {
                newone3.SetActive(true);
            }

            if (i == 3)
            {
                newone4.SetActive(true);
            }

            if (i == 3)
            {
                i = 0;
            }
            else i++;



        }
    }
    // Update is called once per frame
    void Update()
    {

        //OnMouseEnter();
        //OnMouseExit();
        if (open == 1)
        {
            ShowEachIngredient();

        }
    }
}
