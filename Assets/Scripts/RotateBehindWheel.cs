using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehindWheel : MonoBehaviour
{
    public GameObject player;
    private float horizonatalInput;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = player.transform.rotation;
    }
}
