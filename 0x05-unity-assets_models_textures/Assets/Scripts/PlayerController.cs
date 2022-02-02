using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpHeight = 5.0f;
    public float gravity = -10.0f;
    public GameObject player;
    private Rigidbody rb;

    public Transform spawnPoint;

    public bool isGrounded;

    private Vector3 move;



    /// <summary>Sets rigidbody and sets isGrounded bool to true at start of scene</summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    /// <summary>
    /// Checks if player is grounded, then sets velocity to move player
    /// </summary>
    void FixedUpdate()
    {
        if (isGrounded == true)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Jump") * jumpHeight, Input.GetAxis("Vertical") * speed);
        }            
    }

    /// <summary>Updated every scene, checks if player is freefalling. If so, respawns player at 0, 0, 0</summary>
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            player.transform.position = spawnPoint.position;
            rb.velocity = new Vector3(0, 0, 0);
        }

        
    }

    /// <summary>If player enters collision with a ground GameObject, sets isGrounded bool to true</summary>
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Enter");
        if (other.gameObject.tag=="Floor")
            isGrounded = true;
        Debug.Log(isGrounded);
    }

    /// <summary>If player exits collision with a ground GameObject, sets isGrounded bool to false</summary>
    void OnCollisionExit(Collision other)
    {
        Debug.Log("Exit");
        //Debug.Log("Not Grounded");
        if (other.gameObject.tag=="Floor")
            isGrounded = false;
        Debug.Log(isGrounded);
    }
}
