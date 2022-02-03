using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projector : MonoBehaviour
{
    public GameObject parts;


    void /// <summary>
    /// Turns projector on when an object collides with it.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    OnTriggerEnter(Collider other)
    {
        parts.SetActive(true);
    }
}
