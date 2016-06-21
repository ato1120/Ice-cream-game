using UnityEngine;  
using System.Collections;  
  
public class showscore : MonoBehaviour   
{  
    GameObject m_obj1;
    GameObject m_obj2;
    GameObject m_obj3;
    GameObject m_obj4;
    // Use this for initialization  
    void Start()
    {  
        m_obj1 = GameObject.Find("price (1)");
        m_obj1.SetActive(false);
        m_obj3 = GameObject.Find("price (3)");
        m_obj3.SetActive(false);
        m_obj4 = GameObject.Find("price (4)");
        m_obj4.SetActive(false);
    }  
      
    // Update is called once per frame  
    void Update()
    {  
      
    }  
  //press key w the object show, press key A the object disappear
    void OnGUI()
    {  
  
        if (Input.GetKeyDown(KeyCode.W))  
        {  
           // m_obj.enabled = true;  
            m_obj1.SetActive(true);
            m_obj3.SetActive(true);
            m_obj4.SetActive(true);
        }  
  
        if (Input.GetKeyDown(KeyCode.A))  
        {  
            m_obj1.SetActive(false);
            m_obj3.SetActive(false);
            m_obj4.SetActive(false);
            // m_obj.enabled = false;  
        }

    }  
}  
