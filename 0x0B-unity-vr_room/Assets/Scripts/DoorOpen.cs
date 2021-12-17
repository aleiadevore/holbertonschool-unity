using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
            animator.SetBool("character_nearby", true);
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetBool("character_nearby", false);
    }

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
