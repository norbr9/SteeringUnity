using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilinderAgent : AgentNPC
{
    public override bool applySteering(string input)
    {
        transform.position += Vector3.ClampMagnitude(velocity + steering.lineal * 2, maxSpeed);
        transform.forward = velocity.normalized;

        return true;
    }
}
