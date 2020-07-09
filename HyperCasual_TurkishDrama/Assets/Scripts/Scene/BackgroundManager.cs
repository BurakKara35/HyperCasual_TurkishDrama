using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject[] g_Backgrounds;

    public void OpenAllBackground()
    {
        for(int i = 0; i < g_Backgrounds.Length; i++)
        {
            g_Backgrounds[i].SetActive(true);
        }
    }

    public void CloseBackground(int count)
    {
        g_Backgrounds[count - 1].SetActive(false);
    }
}