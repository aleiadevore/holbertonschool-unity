using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
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
}
