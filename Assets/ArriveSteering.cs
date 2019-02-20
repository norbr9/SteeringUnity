using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveSteering : BasicSteering
{

     /**
     * At each step the character tries to reach its target in
     * this duration. This means it moves more slowly when nearby.
     */
    private float timeToTarget = 2f;

    public override void setSteering(AgentNPC agent)
    {   

        // Get direction to the target
        agent.steering.lineal = target.transform.position - agent.transform.position;

        // If there is no direction, do nothing
        if (agent.steering.lineal.sqrMagnitude < target.exteriorRadius * target.exteriorRadius){
            agent.steering.clear();
            return;
        }


        agent.steering.lineal  *= (1.0f) / timeToTarget;

        // If that is too fast, then clip the speed
        if (agent.steering.lineal.sqrMagnitude > agent.maxSpeed * agent.maxSpeed){
            agent.steering.lineal = agent.steering.lineal.normalized;
            agent.steering.lineal *= agent.maxSpeed;
        }


        // Set new orientation
        agent.steering.angular = getNewOrientation(agent.transform.rotation.y, agent.steering.lineal);
       




    
        
    }

}
