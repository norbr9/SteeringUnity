using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBehaviour
{
    public Agent target;


    public abstract Steering getSteering(AgentNPC agent);

}
