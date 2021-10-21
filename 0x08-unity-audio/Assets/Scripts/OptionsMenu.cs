using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer Mixer;
    public bool isInverted = false;
    public Slider BGMslider;
    public Slider SFXslider;
    // Start is called before the first frame update
    void Start()
    {
        BGMslider.value = PlayerPrefs.GetFloat("BGMVol");
        SFXslider.value = PlayerPrefs.GetFloat("SFXVol");
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
        PlayerPrefs.SetFloat("BGMVol", sliderValue);
    }

    public void SetSFX(float sliderValue)
    {
        Mixer.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXVol", sliderValue);
    }

    public void Apply()
    {
        PlayerPrefs.Save();
    }
}
