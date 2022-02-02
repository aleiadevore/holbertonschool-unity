using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseCanvas;
    public Button resumeButton;
    public Button restartButton;
    public Button menuButton;
    public Button optionsButton;
    public string SceneName;
    private Timer timeScript;


    /// <summary>Adds listeners to buttons and sets timeScripts and isPaused values on start of Pause</summary>
    void Start()
    {
        isPaused = false;

        timeScript = GetComponent<Timer>();

        Button ResumeButton = resumeButton.GetComponent<Button>();
        ResumeButton.onClick.AddListener(Resume);

        Button RestartButton = restartButton.GetComponent<Button>();
        RestartButton.onClick.AddListener(Restart);

        Button MenuButton = menuButton.GetComponent<Button>();
        MenuButton.onClick.AddListener(MainMenu);

        Button OptionsButton = optionsButton.GetComponent<Button>();
        OptionsButton.onClick.AddListener(Options);
    }

    /// <summary>Calls Pause method when player presses escape key</summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
    }

    /// <summary>Loads pause menu and pauses timer</summary>
    public void Pause()
    {
        Debug.Log("Paused");
        isPaused = true;
        pauseCanvas.gameObject.SetActive(true);
        timeScript.Pause();

    }

    /// <summary>Exits pause menu and resumes timer</summary>
    public void Resume()
    {
        Debug.Log("Resume");
        isPaused = false;
        pauseCanvas.gameObject.SetActive(false);
        timeScript.Resume();
    }

    /// <summary>Restarts scene</summary>
    public void Restart()
    {
        SceneManager.LoadScene(SceneName);
    }

    /// <summary>Loads Main Menu</summary>
    public void MainMenu()
    {
        Debug.Log("Main menu clicked");
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>Loads Options Menu</summary>
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
