using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class chooseCorrect : MonoBehaviour
{
    public int next_level;
    public void onClick(){
        int current = PlayerPrefs.GetInt("level");
        int maxx = Math.Max(current, next_level);
        PlayerPrefs.SetInt("level", maxx);
        PlayerPrefs.Save();
    }
}
