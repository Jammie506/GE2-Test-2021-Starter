using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent (typeof(DogMain))]
public abstract class MainBrain:MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public DogMain ShipMain;

    public void Awake()
    {
        ShipMain = GetComponent<DogMain>();
    }

    public abstract Vector3 Calculate();
}