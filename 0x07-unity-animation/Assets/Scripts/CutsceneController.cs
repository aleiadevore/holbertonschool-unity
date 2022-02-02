using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public Animator animator;
    public GameObject timerCanvas;
    public GameObject player;
    private GameObject cutsceneCamera;
    public GameObject mainCamera;

    /// <summary>Sets variable values at start of scene</summary>
    void Start()
    {
        // Finds CutsceneCamera
        cutsceneCamera = GameObject.Find("CutsceneCamera");
        // Finds scene number
        Scene scene = SceneManager.GetActiveScene();
        int sceneNumber = scene.buildIndex;
        // Subtracts 1 to get level number and gives it to animator
        animator.SetInteger("Scene", sceneNumber - 1);
        Debug.Log(animator.GetInteger("Scene"));
    }

    /// <summary>Handles completion of animation</summary>
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        { 
            // If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
            Debug.Log("Animation complete");
            // Prepares timer
            timerCanvas.gameObject.SetActive(true);
            // Enables player movement
            player.GetComponent<PlayerController>().enabled = true;
            player.GetComponent<ThirdPersonController>().enabled = true;
            // Switches from animation camera to game camera
            mainCamera.gameObject.SetActive(true);
            cutsceneCamera.gameObject.SetActive(false);
        }
    }

}
