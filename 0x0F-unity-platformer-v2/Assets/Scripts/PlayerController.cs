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


    ///<summary>Resets sound to player prefs on scene load</summary>
    void Start()
    {
        float BGMVol = PlayerPrefs.GetFloat("BGMVol");
        float SFXVol = PlayerPrefs.GetFloat("SFXVol");
        Mixer.SetFloat("BGMVol", Mathf.Log10(BGMVol) * 20);
        Mixer.SetFloat("SFXVol", Mathf.Log10(SFXVol) * 20);
    }

    /// <summary>Respawns player if player enters frefall</summary>
    void Update()
    {     
        if (player.transform.position.y < -6)
        {
            player.transform.position = spawnPoint.position;
        }
    }
}
