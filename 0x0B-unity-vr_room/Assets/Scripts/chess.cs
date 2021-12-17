using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chess : MonoBehaviour
{
    public GameObject projector;
    public Material glove2;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 4)
            projector.SetActive(true);
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "chess")
        {
            count++;
            other.GetComponent<MeshRenderer>().material = glove2;
        }

    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "chess")
            count--;   
    }
}
