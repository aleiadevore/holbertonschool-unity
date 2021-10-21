using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer Mixer;
    public bool isInverted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void /// <summary>
    /// </summary>
    Options()
    {
        string prev = PlayerPrefs.GetString("sceneName");
        SceneManager.LoadScene(prev);
    }

    public void /// <summary>
    /// </summary>
    Back()
    {
        string prev = PlayerPrefs.GetString("sceneName");
        SceneManager.LoadScene(prev);
    }

    public void 
    ///<summary>Sets playerPref isInverted to 0 if false or 1 if true</summary>
    Inversion()
    {
        // Change so that checks if isInverted exists in player prefs
        // if not, add and set to 0
        // otherwise, use PlayerPrefs.isInverted instead of bool
        // isInverted bool should instead be saved on Start for back button
        if (isInverted)
        {
            isInverted = false;
            PlayerPrefs.SetInt("isInverted", 0);
            Debug.Log("False");
        }
        else
        {
            isInverted = true;
            PlayerPrefs.SetInt("isInverted", 1);
            Debug.Log("True");
        }
    }

    public void SetBGM(float sliderValue)
    {
        /* sliderValue is a float, but audio is logarithmic. Convert so sound isn't too sensitive */
        Mixer.SetFloat("BGMVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSFX(float sliderValue)
    {
        Mixer.SetFloat("RunningVol", Mathf.Log10(sliderValue) * 20);
        Mixer.SetFloat("LandingVol", Mathf.Log10(sliderValue) * 20);
        Mixer.SetFloat("AmbVol", Mathf.Log10(sliderValue) * 20);
    }

    public void Apply()
    {
        PlayerPrefs.Save();
    }
}
