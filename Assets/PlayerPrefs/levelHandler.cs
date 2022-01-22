using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelHandler : MonoBehaviour
{
    void Start(){
        if(!PlayerPrefs.HasKey("level")){
            PlayerPrefs.SetInt("level", 1);
            PlayerPrefs.Save();
        }
    }
}
