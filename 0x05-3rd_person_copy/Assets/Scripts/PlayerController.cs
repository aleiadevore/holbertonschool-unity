using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*public GameObject player;
    public Transform spawnPoint;
    public GameObject cap;*/


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {     
        //cap.GetComponent<MeshRenderer>().material.color = Color.red;
        if (transform.position.y < -6)
        {
            transform.position = new Vector3(0, 10, 0);
        }
    }

}
