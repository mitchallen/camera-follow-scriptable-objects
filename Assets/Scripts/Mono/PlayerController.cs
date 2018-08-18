using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    private CharacterController _controller;

    public PlayerPosition playerPosition;

    // Use this for initialization
    void Start () {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {

        Vector3 next = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
         if (next != Vector3.zero)
             transform.rotation = Quaternion.LookRotation(next);
         _controller.Move(next / 8);

        playerPosition.position = transform.position;
        playerPosition.rotation = transform.rotation;
    }
}