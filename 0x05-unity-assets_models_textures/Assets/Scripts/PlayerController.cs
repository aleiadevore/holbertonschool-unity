using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpHeight = 5.0f;
    public float gravity = 150.0f;
    private Rigidbody rb;

    /*private CharacterController controller;

    private Vector3 playerVelocity;
    private bool groundedPlayer;*/


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Jump") * speed, Input.GetAxis("Vertical") * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
