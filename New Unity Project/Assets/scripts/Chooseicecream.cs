using UnityEngine;
using System.Collections;

public class Chooseicecream : MonoBehaviour
{
    //change the color of object when mouse put on it 
    private Color mouseOverColor = Color.blue;//   declare the variable value of blue
    private Color originalColor;//  declare a variable to store the original color

    // Use this for initialization
    void Start()
    {
        originalColor = GetComponent<Renderer>().sharedMaterial.color;// get the original color of the object at the beginning  

    }
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = mouseOverColor;//change the color when mouse put on the object
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = originalColor;//change the color to the original when mouse move away
    }

    IEnumerator OnMouseDown()
    {
        Vector3 screenSpace = Camera.main.WorldToScreenPoint(transform.position);//change the three-dimensional coordinate into screen coordinate
        // change the three-dimensional coordinate into screen coordinate, and then calculate the distance between the place of object and place of the mouse
        var offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
        print("down");
        while (Input.GetMouseButton(0))
        {
            Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
            transform.position = curPosition;
            yield return new WaitForFixedUpdate();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
