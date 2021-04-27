using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailWag : MonoBehaviour
{
    public float wagSpeed;
    private float wait;
    
    private void Update()
    {
        float angle = Mathf.Sin(Time.time) * 70;
        
        this.transform.rotation = Quaternion.Euler(0, angle, 0);
        
        Debug.Log(angle);
    }
}
