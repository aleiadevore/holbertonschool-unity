using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        /*rb = GetComponent<Rigidbody>();
        isGrounded = true;*/
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        //Debug.Log(isGrounded);
        /*if (isGrounded == true)
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Jump") * jumpHeight, Input.GetAxis("Vertical") * speed);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -6)
        {
            player.transform.position = spawnPoint.position;
            /*rb.velocity = new Vector3(0, 0, 0);*/
        }
    }

    void OnCollisionEnter(Collision other)
    {
        /*Debug.Log("Enter");
        //Debug.Log("Grounded");
        if (other.gameObject.tag=="Floor")
            isGrounded = true;
        Debug.Log(isGrounded);*/
    }

    void OnCollisionExit(Collision other)
    {
        /*Debug.Log("Exit");
        //Debug.Log("Not Grounded");
        if (other.gameObject.tag=="Floor")
            isGrounded = false;
        Debug.Log(isGrounded);*/
    }
}
