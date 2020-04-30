﻿using System.Collections;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI;

    [Header("Set Dynamically")]
    public float camZ;
    void Awake()
    {
        camZ = this.transform.position.z;
    }

    void FisedUpdate()
    {
        if (POI == null) return;
        Vector3 destination = POI.transform.position;
        destination.z = camZ;
        transform.position = destination;
    }
}