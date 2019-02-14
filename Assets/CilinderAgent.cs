using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilinderAgent : AgentNPC
{
    public override bool applySteering(string input)
    {
       
        transform.position = transform.position + steering.lineal * maxSpeed;


        return true;
    }
}
