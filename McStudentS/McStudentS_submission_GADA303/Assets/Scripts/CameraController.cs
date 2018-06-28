﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject follow;
    private Vector3 cameraOffset;

    // Use this for initialization
    void Start () {

        cameraOffset = transform.position - follow.transform.position;

    }

    void LateUpdate () {

        transform.position = follow.transform.position + cameraOffset;

    }
}
