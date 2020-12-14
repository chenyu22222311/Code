using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.EventSystems;
public class MouseControl1: MonoBehaviour
{ 
private Touch oldTouch1;
private Touch oldTouch2;
private float _x=0.0f;
private float _y=0.0f;
public float Speed=10f;
private float distance=0.0f;
public  Transform target;
private float minVertical=50;
private float maxVertical=90;
private float minDistance=20;
private float maxDistance=50;
    // Start is called before the first frame update
    void Start()
    {
      distance=(transform.position-target.position).magnitude;
    }

    // Update is called once per frame
void Update()
{
  if (Input.touchCount <= 0)
{
    return;
}
if(Input.touchCount==1)
{
_x=transform.eulerAngles.y;
_y=transform.eulerAngles.x;
if(Input.GetTouch(0).phase == TouchPhase.Moved)
{
if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
{
float x=Input.GetAxis("Mouse X");
float y=Input.GetAxis("Mouse Y");
_x+=x*Time.deltaTime*Speed;           
_y+=y*Time.deltaTime*Speed; 
SetPos(_x,_y);
}
}

}



if(Input.GetAxis("Mouse ScrollWheel")!=0)
{
distance-=Input.GetAxis("Mouse ScrollWheel");
distance=Mathf.Clamp(distance,minDistance,maxDistance);
SetPos(_x,_y);
}
}
void SetPos(float _x,float _y)
{
_y=ClampAngle(_y,minVertical ,maxVertical);
var rotation=Quaternion.Euler(_y,_x,0.0f);
var Position=rotation*new Vector3(0.0f,0.0f,-distance)+target.position;
transform.rotation=rotation;
transform.position=Position;
}
static float ClampAngle(float angle,float min,float max)
{
if(angle<-360)
{
angle+=360;
}
if(angle>360)
{
angle-=360;
}
return Mathf.Clamp(angle,min,max);
}
}
