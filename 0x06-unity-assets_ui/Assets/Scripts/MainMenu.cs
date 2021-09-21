using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LevelOne()
    {
        Debug.Log("Clicked");
        SceneManager.LoadScene("Level01");
    }

    void LevelTwo()
    {
        SceneManager.LoadScene("Level02");
    }

    void LevelThree()
    {
        SceneManager.LoadScene("Level03");
    }

    void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
