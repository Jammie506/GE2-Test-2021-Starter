using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailWag : MonoBehaviour
{
    [SerializeField] private Rigidbody rB;
    [SerializeField] private Vector3 eularRot;
    private Quaternion deltaRotation;
    public float wagSpeed;
    
    void Start()
    {
        eularRot = new Vector3(0, 0, wagSpeed);
    }

    
    void Update()
    {
        deltaRotation = Quaternion.Euler(eularRot * Time.fixedDeltaTime);
        rB.MoveRotation(rB.rotation * deltaRotation);
    }
}
