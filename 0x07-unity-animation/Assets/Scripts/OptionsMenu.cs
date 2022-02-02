using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public bool isInverted = false;


    public void
    /// <summary>
    /// Gets previous scene from PlayerPrefs and reloads scene
    /// </summary>
    Options()
    {
        string prev = PlayerPrefs.GetString("sceneName");
        SceneManager.LoadScene(prev);
    }

    public void
    /// <summary>
    /// Gets previous scene from PlayerPrefs and reloads scene
    /// </summary>
    Back()
    {
        string prev = PlayerPrefs.GetString("sceneName");
        SceneManager.LoadScene(prev);
    }

    public void 
    /// <summary>Sets playerPref isInverted to 0 if false or 1 if true</summary>
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

    /// <summary>Saves player preferences</summary>
    public void Apply()
    {
        PlayerPrefs.Save();
    }
}
