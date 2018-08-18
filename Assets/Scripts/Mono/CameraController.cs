using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerPosition playerPosition;

    public CameraOffset cameraOffset;

    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        transform.position = playerPosition.position + cameraOffset.position;
    }
}