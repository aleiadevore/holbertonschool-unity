using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    /// <summary>Updates timer after player starts to move</summary>

    public Text TimerText;
    private float secondsCount = 00.00F;
    private int minutesCount = 0;
    public bool isPaused = false;
    public Text WinText;

    /// <summary>Sets isPaused bool to true</summary>
    public void Pause()
    {
        isPaused = true;
    }

    /// <summary>Sets isPaused bool to false</summary>
    public void Resume()
    {
        isPaused = false;
    }

    /// <summary>Calls method to update time displayed</summary>
    void FixedUpdate()
    {
        if (isPaused == false)
            UpdateTimerUI();
    }

    /// <summary>Updates time displayed</summary>
    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        TimerText.text = minutesCount + ":" + secondsCount.ToString("00.00");
        if (secondsCount >= 60)
        {
            minutesCount++;
            secondsCount = 0;
        }
    }

    /// <summary>Handles win. Sets isPaused bool to true and updates the winning time text.</summary>
    public void Win()
    {
        isPaused = true;
        WinText.text = TimerText.text;
        TimerText.text = "";
    }
}
