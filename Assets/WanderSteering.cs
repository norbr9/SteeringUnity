using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderSteering : BasicSteering
{
    public override void setSteering(AgentNPC agent)
    {   
        // Move forward in the current direction
        agent.steering.lineal = agent.transform.rotation * Vector3.forward;
        agent.steering.lineal *= agent.maxSpeed;

        // Turn a little
        float change = Random.Range(-50f,50f);
        agent.steering.angular = change * agent.maxRotation ;
    }
}
