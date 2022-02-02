using UnityEngine;
 using System.Collections;
 
public class GameMusicPlayer : MonoBehaviour
{ 
    private static GameMusicPlayer instance = null;

    /// <summary>Getter for instance of music player</summary>
    public static GameMusicPlayer Instance
    {
        get { return instance; }
    }

    /// <summary>Keeps music playing consistently across scenes</summary>
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
