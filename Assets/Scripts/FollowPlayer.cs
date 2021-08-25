using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera behindVehicle;
    public Camera behindWheel;
    public string cameraSwapKey;

    // Offset follows an empty object holding cameras
    private Vector3 offset = new Vector3(0, 0, 0);
    
    void Start()
    {
        behindVehicle.enabled = true;
        behindWheel.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(cameraSwapKey))
        {
            behindVehicle.enabled = !behindVehicle.enabled;
            behindWheel.enabled = !behindWheel.enabled;
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
