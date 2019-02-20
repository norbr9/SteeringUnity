using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Kinematic : MonoBehaviour
{
    public float mass;
    public float maxAcceleration;
    public float maxSpeed;
    public float maxRotation;


    // Transform incluye position y rotation
    public Transform transform;


   
    
}
