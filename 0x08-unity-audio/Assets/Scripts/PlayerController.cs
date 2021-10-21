using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;
    public GameObject cap;
    public AudioMixer Mixer;


    // Start is called before the first frame update
    void Start()
    {
        /* Reset sound to player prefs */
        float BGMVol = PlayerPrefs.GetFloat("BGMVol");
        float SFXVol = PlayerPrefs.GetFloat("SFXVol");
        Mixer.SetFloat("BGMVol", Mathf.Log10(BGMVol) * 20);
        Mixer.SetFloat("SFXVol", Mathf.Log10(SFXVol) * 20);
    }

    // Update is called once per frame
    void Update()
    {     
        //cap.GetComponent<MeshRenderer>().material.color = Color.red;
        if (player.transform.position.y < -6)
        {
            player.transform.position = spawnPoint.position;
        }
    }
}
