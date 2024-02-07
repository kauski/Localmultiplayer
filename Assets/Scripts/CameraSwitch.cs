using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    private bool switchCamera = false;
    public Camera mainCamera;
    public Camera fpCamera;
    public bool player;
    // Start is called before the first frame update
    void Start()
    {
      //Camera settings for local multiplayer
        mainCamera.enabled = !switchCamera;
        fpCamera.enabled = switchCamera;
        if (player == true)
        {
            mainCamera.rect = new Rect(0f, 0f, 0.5f, 1f);
            fpCamera.rect = new Rect(0f, 0f, 0.5f, 1f);
        }
        else
        {
            mainCamera.rect = new Rect(0.5f, 0f, 0.5f, 1f);
            fpCamera.rect = new Rect(0.5f, 0f, 0.5f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //switch between cameras
        if(Input.GetKeyDown(KeyCode.H))
        {
            switchCamera = !switchCamera;
            mainCamera.enabled = !switchCamera;
            fpCamera.enabled = switchCamera;
        }

    }
}
