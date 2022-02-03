using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class getPlane : MonoBehaviour
{
    ARPlaneManager planeManager;

    /// <summary>Logs each plane found in planeManager</summary>
    void Update()
    {
        foreach (var plane in planeManager.trackables)
        {
            plane.GameObject.name
            Debug.Log(plane.gameObject.GetInstanceID);
        }
    }
}
