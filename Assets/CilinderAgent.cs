using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilinderAgent : AgentNPC
{
    public override bool applySteering(string input)
    {
        Debug.Log("Tranform position" + transform.position);
        Debug.Log("Steering velocity" + steering.lineal);

        
        transform.position = transform.position + steering.lineal * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, steering.angular, 0);
        

        return true;
    }
}
