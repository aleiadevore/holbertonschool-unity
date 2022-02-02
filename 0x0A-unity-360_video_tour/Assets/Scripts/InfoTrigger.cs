using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTrigger : MonoBehaviour
{
    public GameObject panel;
    private bool isActive;

    /// <summary>Sets bool checking if info is active to false at beginning of scene</summary>
    void Start()
    {
        isActive = false;
    }

    /// <summary>Handles button press to open or close info text</summary>
    public void ButtonPressed()
    {
        Debug.Log("Button pressed");
        // If info already open, close
        if (isActive)
        {
            isActive = false;
            CloseInfo();
        }
        // If info closed, open it
        else
        {
            isActive = true;
            OpenInfo();
        }
    }

    /// <summary>Closes info panel</summary>
    private void CloseInfo()
    {
        panel.SetActive(false);
    }

    /// <summary>Opens info panel</summary>
    private void OpenInfo()
    {
        panel.SetActive(true);
    }
}
