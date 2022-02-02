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

    /// <summary>Calls method to update time displayed</summary>
    void FixedUpdate()
    {
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
}
