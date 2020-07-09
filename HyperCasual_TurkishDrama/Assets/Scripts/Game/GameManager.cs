using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    CameraControl cameraControl;
    CanvasManager canvasManager;

    KeyCode k_Space = KeyCode.Space;
    KeyCode k_Mouse = KeyCode.Mouse0;
    KeyCode k_Exit = KeyCode.Escape;

    bool b_Tap = false;
    bool b_Escape = false;

    void Awake()
    {
        cameraControl = Camera.main.gameObject.GetComponent<CameraControl>();
        canvasManager = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasManager>();

        canvasManager.text_Episode.text = canvasManager.GetEpisodeNumber() + ". BÖLÜM";
    }

    void Update()
    {
        b_Tap = Input.GetKeyDown(k_Mouse) || Input.GetKeyDown(k_Space);
        b_Escape = Input.GetKeyDown(k_Exit); 

        if (b_Tap)
            cameraControl.ChangeCameraPoint();

        if (b_Escape)
            Application.Quit();
    }
}