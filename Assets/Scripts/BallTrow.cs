using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrow : MonoBehaviour
{
    [SerializeField] private float throwRate = 15f;
    [SerializeField] private float nextTimeToFire = 0f;
    [SerializeField] private GameObject Ball;
    [SerializeField] private float speed = 20;
    [SerializeField] private Transform Hand;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / throwRate;
            Throw();
        }
    }
    public void Throw()
    {
        GameObject gren = Instantiate(Ball, Hand.position, Hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(Hand.forward * speed, ForceMode.Impulse);
    }
}
