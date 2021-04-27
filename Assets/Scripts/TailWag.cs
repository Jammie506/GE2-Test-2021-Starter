using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailWag : MainBrain
{
    [SerializeField] public float frequency = 0.3f;
    [SerializeField] public float radius = 10.0f;

    [SerializeField] public float theta = 0;
    [SerializeField] public float amplitude = 80;
    [SerializeField] public float distance = 5;

    public enum Axis { Horizontal, Vertical};

    [SerializeField] public Axis axis = Axis.Horizontal;

    Vector3 target;
    Vector3 worldTarget;

    public override Vector3 Calculate()
    {
        float n  = Mathf.Sin(theta);
        float angle = n * amplitude * Mathf.Deg2Rad;

        Vector3 rot = transform.rotation.eulerAngles;

        rot.x = 0;
        if (axis == Axis.Horizontal)
        {
            target.x = Mathf.Sin(angle);
            target.z = Mathf.Cos(angle);
            rot.z = 0;
        }
        else
        {
            target.y = Mathf.Sin(angle);
            target.z = Mathf.Cos(angle);
        }
        target *= radius;

        Vector3 localtarget = target + Vector3.forward * distance;
        worldTarget = transform.position + Quaternion.Euler(rot) * localtarget;

        theta += frequency * Time.deltaTime * Mathf.PI * 2.0f;

        return ShipMain.SeekForce(worldTarget);
    }
}