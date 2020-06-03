using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitTest : MonoBehaviour
{
    private Vector3 target = new Vector3(0.0f, 0.0f, 0.0f);
    public float speedRotate = 2f;


    void Update()
    {
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(target, Vector3.forward, speedRotate * Time.deltaTime);
    }
}

