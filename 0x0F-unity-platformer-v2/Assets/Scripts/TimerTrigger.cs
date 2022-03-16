using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject player;

    /// <summary>
    /// Initiates timer when player exits trigger around starting point
    /// </summary>
    /// <param name="other">Trigger item around player</param>
    void OnTriggerExit(Collider other)
    {
        player.GetComponent<Timer>().enabled = true;
    }
}
