using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;

    /// <summary>If an object enters the collider, checks to see if key present</summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
            animator.SetBool("character_nearby", true);
    }

    /// <summary>Closes door when key leaves collider</summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        animator.SetBool("character_nearby", false);
    }

    /// <summary>Used for testing. If door is open, closes door. If door is closed, opens door</summary>
    public void ClickDoor()
    {
        if (isOpen == false)
        {
            animator.SetBool("character_nearby", true);
            isOpen = true;
        }
        else
        {
            animator.SetBool("character_nearby", false);
            isOpen = false;
        }
    }
}
