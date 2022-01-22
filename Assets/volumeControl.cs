using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject noSound;
    public GameObject thirtySound;
    public GameObject sixtySound;
    public GameObject nintySound;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("volume")){
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
        }
        else{
            volumeSlider.value = 0.5f;
            PlayerPrefs.SetFloat("volume", 0.5f);
            PlayerPrefs.Save();
        }
    }
    void Update()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.Save();
        if(volumeSlider.value == 0){
          noSound.SetActive(true);
          thirtySound.SetActive(false);
          sixtySound.SetActive(false);
          nintySound.SetActive(false);
        }
        else if(volumeSlider.value > 0 && volumeSlider.value <= 0.3){
          noSound.SetActive(false);
          thirtySound.SetActive(true);
          sixtySound.SetActive(false);
          nintySound.SetActive(false);
        }
        else if(volumeSlider.value > 0.3 && volumeSlider.value <= 0.75){
          noSound.SetActive(false);
          thirtySound.SetActive(false);
          sixtySound.SetActive(true);
          nintySound.SetActive(false);
        }
        else{
          noSound.SetActive(false);
          thirtySound.SetActive(false);
          sixtySound.SetActive(false);
          nintySound.SetActive(true);
        }
    }
}