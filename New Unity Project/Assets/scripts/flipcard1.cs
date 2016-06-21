using UnityEngine;
using System.Collections;

public class flipcard1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public float roate_Speed = 100.0f;//旋转速度  rotating speed
void Update()
{  
Transform target_transform = null;//不用绑定对象，下面代码动态获取对象  not need to bind the target, the code follow get the target
if (Input.GetMouseButton(0))  
            {                   
                //在屏幕上转换坐标：将鼠标点转换成射线  change the coordinate: change the point of mouse to radial
                Ray rayObj = Camera.main.ScreenPointToRay(Input.mousePosition);  
                RaycastHit hitObj;  
                if (Physics.Raycast(rayObj, out hitObj))  
                {  
                    //Debug.Log("射线得到的对象名称 radial get the name of target：" + hitObj.collider.name);  
                    target_transform = hitObj.transform;  
                }  
  
  
                if (target_transform != null)  
                {  
                    //Debug.Log("射线取得对象radial get the target");  
                    float mousX = Input.GetAxis("Mouse X") * roate_Speed;//得到鼠标移动距离  get the move distance of the mouse 
                    target_transform.transform.Rotate(new Vector3(0, -mousX, 0));  
                }  
                else  
                {  
                    Debug.Log("无法取得对象cannot get the target");  
                }  
            }  
}  

}
