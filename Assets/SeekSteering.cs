using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekSteering : SteeringBehaviour
{
    public override Steering getSteering(AgentNPC agent)
    {   


        // Get direction to the target
        agent.steering.lineal = target.transform.position  - agent.transform.position;

        agent.steering.lineal = agent.steering.lineal.normalized;
        agent.steering.lineal *= agent.maxSpeed;



        return agent.steering;

    }
}
