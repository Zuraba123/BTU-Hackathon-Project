using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 distanceFromTarget;
    void Start()
    {
        distanceFromTarget = target.position + transform.position;
    }
    void Update()
    {
        transform.position = target.position + distanceFromTarget;
    }
}