using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCube : MonoBehaviour
{

    /// <summary>Moves cube to position of user's tap</summary>
    void Update()
    {
        // Can find multiple touches (multiple finger taps)
        if (Input.touchCount > 0)
        {
            // Select first touch
            Touch touch = Input.GetTouch(0);
            // touch.position is position on screen of touch
            /* touch.phase gives info about current state of touch:
                - Began
                - Ended
                - Moved
                - Stationary
                - Canceled
            */
            // touch position is measured in pixels while GameObjects measured in units. Need to convert using camera.
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 2f;
            transform.position = touchPosition;
        }
    }
}
