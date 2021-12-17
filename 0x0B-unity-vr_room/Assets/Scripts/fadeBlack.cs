using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeBlack : MonoBehaviour
{
    // public GameObject canvas;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
       // canvas.SetActive(false);
       cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Door" && other.tag != "interact" && other.tag != "chess" && other.tag != "key")
        {
            Debug.Log(other);
            // canvas.SetActive(true);
            cube.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Door")
        {
            cube.SetActive(false);
            // canvas.SetActive(false);
        }
    }
}
