using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useThisToPlaySound : MonoBehaviour
{
    // Use with AudioSource
    public AudioSource audioSource;
    void Start(){
        audioSource.Play();
    }
    void Update(){
        audioSource.volume = PlayerPrefs.GetFloat("volume");
        audioSource.loop = true;
    }
}
