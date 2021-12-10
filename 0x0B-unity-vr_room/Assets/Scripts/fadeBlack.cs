using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeBlack : MonoBehaviour
{
    public GameObject canvas;
    public GameObject container;

    // Start is called before the first frame update
    void Start()
    {
       canvas.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Door")
        {
            Debug.Log(other);
            canvas.SetActive(true);
            container.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Door")
        {
            canvas.SetActive(false);
            container.SetActive(true);
        }
    }
}
