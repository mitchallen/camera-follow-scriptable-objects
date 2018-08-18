using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 offset; //Private variable to store the offset distance between the player and camera

    public PlayerPosition playerPosition;

    public CameraStartPosition cameraStartPosition;

    // Use this for initialization
    void Start () {

        offset = cameraStartPosition.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        transform.position = playerPosition.position + offset;
    }
}