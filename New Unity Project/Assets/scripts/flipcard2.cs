using UnityEngine;
using System.Collections;

public class flipcard2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    float speed = 100.0f;
    float x;
    float y;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {//鼠标按着左键移动 
            y = Input.GetAxis("Mouse X") * Time.deltaTime * speed;
            x = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
        }
        else
        {
            x = y = 0;
        }

        //旋转角度（增加）
        transform.Rotate(new Vector3(x, y, 0));
        /**---------------其它旋转方式----------------**/
        //transform.Rotate(Vector3.up *Time.deltaTime * speed);//绕Y轴 旋转 

    }
}