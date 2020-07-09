using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    BackgroundManager backgroundManager;

    [System.Serializable]
    public class BacgroundPlans
    {
        public string s_Tag;
        public int i_Background1;
        public int i_Background2;
    }

    public BacgroundPlans[] bacgroundPlans;

    public Transform[] t_CameraPoints;

    int i_Index = 0;

    void Awake()
    {
        backgroundManager = GameObject.FindGameObjectWithTag("BackgroundManager").GetComponent<BackgroundManager>();

        ChangeCameraPoint();
    }

    Vector3 GetNewCameraPosition()
    {
        return t_CameraPoints[i_Index].position;
    }

    Quaternion GetNewCameraRotation()
    {
        return t_CameraPoints[i_Index].rotation;
    }

    public void ChangeCameraPoint()
    {
        if (i_Index >= t_CameraPoints.Length)
            i_Index = 0;

        backgroundManager.OpenAllBackground();
        backgroundManager.CloseBackground(bacgroundPlans[i_Index].i_Background1);
        backgroundManager.CloseBackground(bacgroundPlans[i_Index].i_Background2);

        transform.position = GetNewCameraPosition();
        transform.rotation = GetNewCameraRotation();
        
        i_Index++;
    }
}