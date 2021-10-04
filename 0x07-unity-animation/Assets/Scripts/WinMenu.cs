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
    // Start is called before the first frame update
    void Start()
    {
        Button MenuButton = menuButton.GetComponent<Button>();
        MenuButton.onClick.AddListener(MainMenu);

        Button NextButton = nextButton.GetComponent<Button>();
        NextButton.onClick.AddListener(Next);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void 
    ///<summary>Opens MainMenu</summary>
    MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        SceneManager.LoadScene(NextScene);
    }
}
