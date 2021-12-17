using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projector : MonoBehaviour
{
    public GameObject parts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    OnTriggerEnter(Collider other)
    {
        parts.SetActive(true);
    }
}
