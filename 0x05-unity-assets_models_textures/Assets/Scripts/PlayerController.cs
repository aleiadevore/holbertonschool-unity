using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpHeight = 5.0f;
    public float gravity = 150.0f;

    private CharacterController controller;

    private Vector3 playerVelocity;
    private bool groundedPlayer;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        groundedPlayer = controller.isGrounded;
        playerVelocity.y = 0f;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump"))
        {
            playerVelocity.y += jumpHeight * speed;
            Debug.Log(playerVelocity);
        }
        playerVelocity.y -= gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
