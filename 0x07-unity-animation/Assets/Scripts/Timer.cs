using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    ///<summary>Updates timer after player starts to move</summary>

    public Text TimerText;
    private float secondsCount = 00.00F;
    private int minutesCount = 0;
    public bool isPaused = false;
    public Text WinText;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Pause()
    {
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPaused == false)
            UpdateTimerUI();
    }

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

    public void Win()
    {
        isPaused = true;
        WinText.text = TimerText.text;
        TimerText.text = "";
    }
}