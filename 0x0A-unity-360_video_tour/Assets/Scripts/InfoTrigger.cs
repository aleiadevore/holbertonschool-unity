using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTrigger : MonoBehaviour
{
    public GameObject panel;
    private bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        Debug.Log("Button pressed");
        if (isActive)
        {
            isActive = false;
            CloseInfo();
        }
        else
        {
            isActive = true;
            OpenInfo();
        }
    }

    private void CloseInfo()
    {
        panel.SetActive(false);
    }

    private void OpenInfo()
    {
        panel.SetActive(true);
    }
}
