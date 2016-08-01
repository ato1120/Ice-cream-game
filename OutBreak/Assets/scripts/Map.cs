using UnityEngine;
using System.Collections;

public class MapCard : MonoBehaviour
{

    public string title;
    public Object mapImg;
    public string fulldescription;
    public int id;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }

}

public class Map : MonoBehaviour {

    MapCard map1;
    // Use this for initialization
    void Start () {

        map1.title = "Biologglab";
        map1.mapImg = GameObject.Find("map1Img");
        map1.fulldescription = "good";
        map1.id = 1;
    }
	
	// Update is called once per frame
	void Update () {
   
    }
}
