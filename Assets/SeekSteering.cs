using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekSteering : SteeringBehaviour
{


    public override void setSteering(AgentNPC agent)
    {   

        // Get direction to the target
        agent.steering.lineal = target.transform.position  - agent.transform.position;

        agent.steering.lineal = agent.steering.lineal.normalized;
        agent.steering.lineal *= agent.maxSpeed;


        // Set new rotation
        myself.transform.rotation = Quaternion.Euler(0,getNewOrientation(myself.transform.rotation.y, agent.steering.lineal),0);
        
    }



    // Rotacion total para apuntar al target
    private float getNewOrientation(float orientation, Vector3 velocity){
        return orientation != Mathf.Atan2(velocity.x,velocity.z) * Mathf.Rad2Deg
             ? Mathf.Atan2(-velocity.x, velocity.z) * Mathf.Rad2Deg : orientation;
    }


}
