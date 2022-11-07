
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
public Transform target;
//public Transform target2;
//public Transform target3;


public Vector3 offset;
[Range(1,10)]
//public Vector3 offset2;
//[Range(1,10)]
//public Vector3 offset3;
//[Range(1,10)]
public float smoothFactor;
    
   private void FixedUpdate(){
        Follow();
   }
   void Follow(){
       Vector3 Show1 = target.position + offset;
       //Vector3 Show2 =  target2.position + offset2;
    //   Vector3 Show3 =  target3.position + offset3;

       Vector3 smoothedPosition = Vector3.Lerp(transform.position,transform.position,smoothFactor*Time.fixedDeltaTime);
       transform.position = Show1  ;

   }
}
