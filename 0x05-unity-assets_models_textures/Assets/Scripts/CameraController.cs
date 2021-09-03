using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    private Vector3 target_Offset;
    // Start is called before the first frame update
    void Start()
    {
        target = player.transform;
        target_Offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 0.1f);
    }
}
