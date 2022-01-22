using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_PlayerPref : MonoBehaviour
{
    public void onClick(){
        int now = PlayerPrefs.GetInt("level");
        PlayerPrefs.SetInt("level", now + 1);
        PlayerPrefs.Save();      
        Debug.Log("Level: " + PlayerPrefs.GetInt("level"));
    }
}
