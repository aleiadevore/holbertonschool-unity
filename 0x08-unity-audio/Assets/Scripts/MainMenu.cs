using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
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
        
    }

    public void LevelSelect(int level)
    {
        string l = "Level0" + level;
        SceneManager.LoadScene(l);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
