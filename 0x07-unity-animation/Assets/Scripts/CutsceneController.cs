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
    // Start is called before the first frame update
    void Start()
    {
        cutsceneCamera = GameObject.Find("CutsceneCamera");
        Scene scene = SceneManager.GetActiveScene();
        int sceneNumber = scene.buildIndex;
        animator.SetInteger("Scene", sceneNumber - 1);
        Debug.Log(animator.GetInteger("Scene"));
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        { 
            //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
            Debug.Log("Animation complete");
            timerCanvas.gameObject.SetActive(true);
            player.GetComponent<PlayerController>().enabled = true;
            player.GetComponent<ThirdPersonController>().enabled = true;
            mainCamera.gameObject.SetActive(true);
            cutsceneCamera.gameObject.SetActive(false);
        }
    }

}
