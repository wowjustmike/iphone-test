using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public float distanceFromTarget = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        transform.position = target.position - transform.forward * distanceFromTarget;

    }
}
