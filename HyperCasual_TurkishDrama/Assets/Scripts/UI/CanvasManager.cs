using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Text text_Episode;

    public int GetEpisodeNumber()
    {
        return Random.Range(100, 400);
    }   
}