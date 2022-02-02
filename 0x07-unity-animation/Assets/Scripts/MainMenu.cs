using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
