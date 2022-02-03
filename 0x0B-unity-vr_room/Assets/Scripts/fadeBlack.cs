using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeBlack : MonoBehaviour
{
    public GameObject cube;

    /// <summary>Sets cube to inactive on scene load</summary>
    void Start()
    {
       cube.SetActive(false);
    }

    /// <summary>Makes cube active if user tries to go through GameObject</summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        // Making sure collision isn't with an object that should be able to be close to face
        if (other.tag != "Door" && other.tag != "interact" && other.tag != "chess" && other.tag != "key")
        {
            Debug.Log(other);
            cube.SetActive(true);
        }
    }

    /// <summary>Deactivates cube when player moves away from GameObject</summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Door")
        {
            cube.SetActive(false);
        }
    }
}
