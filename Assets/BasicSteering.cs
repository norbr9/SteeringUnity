using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicSteering : SteeringBehaviour 
{
    
    protected float getNewOrientation(float orientation, Vector3 velocity){
         /* return orientation != Mathf.Atan2(velocity.x,velocity.z) * Mathf.Rad2Deg
               ? Mathf.Atan2(-velocity.x, velocity.z) * Mathf.Rad2Deg : orientation;*/

       return Mathf.Atan2(velocity.x, velocity.z) * Mathf.Rad2Deg;
    }

}
