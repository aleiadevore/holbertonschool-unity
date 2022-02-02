using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text TimerText;
    public Canvas WinCanvas;
    public Timer timeScript;

    /// <summary>Triggers canvas text to display winning time when player collides with flag<summary>
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Winner");
        if (other.gameObject.name == "Player")
        {
            player.GetComponent<Timer>().enabled = false;
            // Calls win method to set winning time
            player.GetComponent<Timer>().Win();
            // Opens win screen
            WinCanvas.gameObject.SetActive(true);
        }
    }
}
