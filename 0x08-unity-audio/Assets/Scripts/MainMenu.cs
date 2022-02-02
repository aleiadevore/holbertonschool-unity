using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer Mixer;

    /// <summary>Loads audio settings based on player preferences</summary>
    void Start()
    {
        /* Reset sound to player prefs */
        float BGMVol = PlayerPrefs.GetFloat("BGMVol");
        float SFXVol = PlayerPrefs.GetFloat("SFXVol");
        Mixer.SetFloat("BGMVol", Mathf.Log10(BGMVol) * 20);
        Mixer.SetFloat("SFXVol", Mathf.Log10(SFXVol) * 20);
    }

    /// <summary>Selects level</summary>
    public void LevelSelect(int level)
    {
        // Creates string for level based on int passed from scene
        string l = "Level0" + level;
        // Loads scene using scene manager.
        SceneManager.LoadScene(l);
    }

    /// <summary>Loads Options scene</summary>
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    /// <summary>Quits game</summary>
    public void Quit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
