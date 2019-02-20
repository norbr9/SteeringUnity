using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderSteering : BasicSteering
{
    public override void setSteering(AgentNPC agent)
    {
        // Move forward in the current direction
        // agent.steering.lineal = new Vector3(Mathf.Sin(agent.transform.rotation.eulerAngles.x), 0, Mathf.Cos(agent.transform.rotation.eulerAngles.z));
        //agent.steering.lineal = new Vector3(agent.transform.rotation.eulerAngles.x, 0, agent.transform.rotation.eulerAngles.z);
        agent.steering.lineal = agent.transform.forward * agent.maxSpeed;
        Debug.Log("rotation euler: " + agent.steering.lineal);
        agent.steering.lineal *= agent.maxSpeed;

        // Turn a little
        float change = Random.Range(-1f, 1f);
        agent.steering.angular = change * agent.maxRotation;
       
     }
}
