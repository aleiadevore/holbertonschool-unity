using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSave : MonoBehaviour
{
    public string SceneName;

    /// <summary>Saves name of current scene to PlayerPrefs. Used in Options to return to previous scene.</summary>
    void Start()
    {
        Debug.Log(SceneName);
        PlayerPrefs.SetString("sceneName", SceneName);
    }
}
