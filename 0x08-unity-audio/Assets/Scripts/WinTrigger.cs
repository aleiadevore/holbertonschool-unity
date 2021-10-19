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
    public AudioSource winSound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Winner");
        if (other.gameObject.name == "Player")
        {
            player.GetComponent<Timer>().enabled = false;
            //timeScript.Win();
            player.GetComponent<Timer>().Win();
            WinCanvas.gameObject.SetActive(true);
            audioSource = player.GetComponent<AudioSource>();
            audioSource.mute = true;
            winSound.Play();
        }

    }
}
