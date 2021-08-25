using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public float rotationSpeed;
    private Vector3 propellerRotation = new Vector3(0.0f, 0.0f, 45.0f);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(propellerRotation * rotationSpeed * Time.deltaTime);
    }
}
