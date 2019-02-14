using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBehaviour
{
    public Agent target;
    public Agent myself;

    public abstract void setSteering(AgentNPC agent);

}
