using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilinderAgent : AgentNPC
{
    public override bool applySteering(Steering steering)
    {
        Debug.Log("Tranform position" + transform.position);
        Debug.Log("Steering velocity" + steering.lineal);
        Debug.Log("Steering angular" + steering.angular);

        


        transform.position +=steering.lineal * Time.deltaTime;
       // transform.rotation = Quaternion.Euler(Mathf.Sin(steering.angular),0,Mathf.Cos(steering.angular));
       if(Random.value < 0.1 )
       transform.rotation = Quaternion.Euler(0, steering.angular, 0);


        

        return true;
    }
}
