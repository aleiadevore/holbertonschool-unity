using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text TimerText;

    /// <summary>Triggers canvas text to display winning time when player collides with flag<summary>
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Winner");
        if (other.gameObject.name == "Player")
        {
            TimerText.color = Color.green;
            TimerText.fontSize = 60;
            player.GetComponent<Timer>().enabled = false;
        }
    }
}
