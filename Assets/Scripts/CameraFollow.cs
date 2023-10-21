using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform PlayerLocation;
    Vector3 gap;


    void Start()
    {
        gap = transform.position - PlayerLocation.position;
    }

    void Update()
    {
        if (PlayerMovement.fall == false)
        {
            transform.position = PlayerLocation.position + gap;
        }
    }
}
