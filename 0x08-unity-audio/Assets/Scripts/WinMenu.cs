using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    public Button menuButton;
    public Button nextButton;
    public GameObject Player;
    public string NextScene = "";


    void 
    /// <summary>Adds listeners to buttons at start of scene</summary>
    Start()
    {
        Button MenuButton = menuButton.GetComponent<Button>();
        MenuButton.onClick.AddListener(MainMenu);

        Button NextButton = nextButton.GetComponent<Button>();
        NextButton.onClick.AddListener(Next);
    }

    public void 
    ///<summary>Opens MainMenu</summary>
    MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void 
    /// <summary>Loads next scene</summary>
    Next()
    {
        SceneManager.LoadScene(NextScene);
    }
}
