using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class BindingsMenu : MonoBehaviour
{
    private Dictionary<string, string> BindsDict;
    public GameObject ForwardInput;
    public GameObject BackInput;
    public GameObject LeftInput;
    public GameObject RightInput;
    [SerializeField] private InputActionReference leftAction;

    private Dictionary<string, GameObject> inputDict;

    /// <summary>Creates dictionary of input forms and dictionary of current keybinds.</summary>
    void Start()
    {
        // Create dict of input values to parse when text is input
        inputDict = new Dictionary<string, GameObject>() {
        {"forward", ForwardInput},
        {"back", BackInput},
        {"left", LeftInput},
        {"right", RightInput}
    };

        // Create dict of keycodes. If none in player settings, set to default values
        /*BindsDict = new Dictionary<string, KeyCode>(){
            {"forward", KeyCode.W},
            {"back", KeyCode.S},
            {"left",KeyCode.A},
            {"right",KeyCode.D}
        };*/
        BindsDict = new Dictionary<string, string>(){
            {"forward", "W"},
            {"back", "S"},
            {"left", "A"},
            {"right", "D"}
        };

        /*if (PlayerPrefs.GetString("FKey") != null)
            BindsDict["forward"] = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("FKey"));
        if (PlayerPrefs.GetString("BKey") != null)
            BindsDict["forward"] = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("BKey"));
        if (PlayerPrefs.GetString("LKey") != null)
            BindsDict["forward"] = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("LKey"));
        if (PlayerPrefs.GetString("RKey") != null)
            BindsDict["forward"] = (KeyCode) System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("RKey"));*/

        if (PlayerPrefs.GetString("FKey") != null)
            BindsDict["forward"] = PlayerPrefs.GetString("FKey");
        if (PlayerPrefs.GetString("BKey") != null)
            BindsDict["forward"] = PlayerPrefs.GetString("BKey");
        if (PlayerPrefs.GetString("LKey") != null)
            BindsDict["forward"] = PlayerPrefs.GetString("LKey");
        if (PlayerPrefs.GetString("RKey") != null)
            BindsDict["forward"] = PlayerPrefs.GetString("RKey");
    }

    public void /// <summary>
    /// Resets key bindings to default
    /// </summary>
    ResetButton()
    {
        /*BindsDict = new Dictionary<string, KeyCode>(){
            {"forward", KeyCode.W},
            {"back", KeyCode.S},
            {"left",KeyCode.A},
            {"right",KeyCode.D}
        };*/

        // Resets text input on screen
        foreach (GameObject comp in inputDict.Values)
            comp.GetComponent<InputField>().text = "";

    }


    public void
    /// <summary>
    /// Returns player to Options scene
    /// </summary>
    Back()
    {
        SceneManager.LoadScene("Options");
    }

    public void Rebind()
    {
        /*leftAction.action.PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete()).Start();
        Debug.Log(leftStart);*/
    }

    private void RebindComplete()
    {
        return;
    }
    
    public void 
    /// <summary>
    /// Assigns key value to dict
    /// </summary>
    InputKey(string Direction)
    {
        GameObject DirObj = inputDict[Direction];
        string keyStr = DirObj.GetComponent<InputField>().text.ToString();
        Debug.Log(keyStr);
        //KeyCode key = (KeyCode) System.Enum.Parse(typeof(KeyCode), keyStr);
        BindsDict[Direction] = keyStr;
    }

    /// <summary>Saves player preferences</summary>
    public void Apply()
    {

        /*leftStart.Start();*/
        // Apply key binds
        Debug.Log(BindsDict["left"]);
        leftAction.action.ApplyBindingOverride("Player", BindsDict["left"]);

        // Save dictionary to player prefs
        PlayerPrefs.SetString("FKey", BindsDict["forward"].ToString());
        PlayerPrefs.SetString("BKey", BindsDict["back"].ToString());
        PlayerPrefs.SetString("LKey", BindsDict["left"].ToString());
        PlayerPrefs.SetString("RKey", BindsDict["right"].ToString());

        // Save player prefs
        PlayerPrefs.Save();
    }
}
