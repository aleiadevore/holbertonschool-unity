using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string url;

    /// <summary>Opens url</summary>
    public void VisitSite()
    {
        Application.OpenURL(url);
    }
}
