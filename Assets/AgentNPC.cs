using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AgentNPC  : Agent, SteeringApplier
{   
    // Inicializar a una lista fija [seek,flee,etc]
    SteeringBehaviour[] listSteerings;

    public Steering steering;

    public Agent target;



    // Start is called before the first frame update
    void Start()
    {
        steering = new Steering();

        listSteerings = new SteeringBehaviour[1];
        listSteerings[0] = new SeekSteering();
        listSteerings[0].myself = this;

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Metodo para seleccionar el steering que se quiera usar que estara en la lista SteeringBehaviour

        foreach(SteeringBehaviour sB in listSteerings)
        {
            sB.target = target;
            sB.setSteering(this);
            applySteering(null);
        }
        
    }


    public abstract bool applySteering(string input);
}
