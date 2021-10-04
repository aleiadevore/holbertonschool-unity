using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSave : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneName);
        PlayerPrefs.SetString("sceneName", SceneName);
        //Debug.Log("Pref set to " + PlayerPrefs.GetString("sceneName"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
