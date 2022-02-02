using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;
    public GameObject cap;
    private Vector3 move;


    /// <summary>Respawns player if player enters frefall</summary>
    void Update()
    {     
        if (player.transform.position.y < -6)
        {
            player.transform.position = spawnPoint.position;
        }
    }
}
