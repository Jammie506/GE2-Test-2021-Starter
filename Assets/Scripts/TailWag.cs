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
        wait = Time.deltaTime;

        if (wait < 1)
        {
            this.transform.rotation = Quaternion.Euler(0, (wagSpeed * wait), 0);
        }
        
    }
}
