using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a GameObject to rotate .
public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    public enum Axis
    {
        AroundX,
        AroundY,
        AroundZ
    }
    public Axis way;
    private Vector3 rotatingWay = Vector3.right;
    void Update()
    {
        switch (way)
        {
            case Axis.AroundX:
                rotatingWay = Vector3.right;
                break;
            case Axis.AroundY:
                rotatingWay = Vector3.up;
                break;
            case Axis.AroundZ:
                rotatingWay = Vector3.forward;
                break;
        }
        // Spin the object around the world origin at 20 degrees/second.
        transform.Rotate(rotatingWay, speed * Time.deltaTime);
    }
}