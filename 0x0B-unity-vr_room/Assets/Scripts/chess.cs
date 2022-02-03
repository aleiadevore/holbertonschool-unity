using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chess : MonoBehaviour
{
    public GameObject projector;
    public Material glove2;
    public int count;

    /// <summary>Sets count to 0 at start of scene</summary>
    void Start()
    {
        count = 0;
    }

    /// <summary>If count reaches 4, activates the projector</summary>
    void Update()
    {
        if (count == 4)
            projector.SetActive(true);
    }

    /// <summary>
    /// If an object collides with the chess board, checks if it is a chess piece.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "chess")
        {
            // Increases count
            count++;
            // Changes chess piece material for visual cue
            other.GetComponent<MeshRenderer>().material = glove2;
        }

    }

    /// <summary>
    /// If object leaves the chess board, checks if it was a chess piece.
    /// This is to keep the player from triggering the projector by putting the same piece on the
    /// board four times.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "chess")
            count--;   
    }
}
