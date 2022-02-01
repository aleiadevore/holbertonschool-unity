using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    ///<summary>Causes coin to rotate on screen</summary>
    void Update()
    {
        gameObject.transform.Rotate(45 * Time.deltaTime, 0, 0);
    }
}
