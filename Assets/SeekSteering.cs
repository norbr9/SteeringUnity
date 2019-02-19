using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekSteering : BasicSteering
{


    public override void setSteering(AgentNPC agent)
    {   

        // Get direction to the target
        agent.steering.lineal = target.transform.position  - agent.transform.position;

        agent.steering.lineal = agent.steering.lineal.normalized;
        agent.steering.lineal *= agent.maxSpeed;


        // Set new rotation
       agent.steering.angular = getNewOrientation(agent.transform.rotation.y, agent.steering.lineal);
        
    }



}
