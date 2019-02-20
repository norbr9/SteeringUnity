using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering
{
    public Vector3 lineal;
    public float angular;



    public void clear(){
        lineal = Vector3.zero;
        angular = 0;
    }
}
