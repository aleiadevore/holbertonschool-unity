using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    /// <summary>Turns flashlight on</summary>
    public void TurnOn()
    {
        flashlight.SetActive(true);
    }

    /// <summary>Turns flashlight off</summary>
    public void TurnOff()
    {
        flashlight.SetActive(false);
    }
}
