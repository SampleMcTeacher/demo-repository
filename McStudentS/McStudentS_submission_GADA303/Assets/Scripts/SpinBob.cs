using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBob : MonoBehaviour {

    private float tempPosY;
    private Vector3 tempPos;
    public float amplitude;
    public float bobSpeed;
    public float heightAdjust;

    // Use this for initialization
    void Start () {

        tempPosY = transform.position.y;
        tempPos = transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate((Vector3.up * 360) * Time.deltaTime, Space.World);

        tempPos.y = tempPosY + heightAdjust + amplitude * Mathf.Sin(bobSpeed * Time.time);

        transform.position = tempPos;

    }
}
