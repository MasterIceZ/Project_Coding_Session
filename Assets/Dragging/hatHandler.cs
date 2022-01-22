using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hatHandler : MonoBehaviour
{
    public static int it;
    public static bool isCorrect;
    public bool debugCorrect;
    private int last_iterator;
    private bool ok;
    public GameObject correctImage, wrongImage, nextButtonCorrect, nextButtonWrong;
    public List<GameObject> hats = new List<GameObject>();
    void Start()
    {
        isCorrect = true;
        ok = false;
        it = 0;
        last_iterator = -1;
        for(int i=0; i<hats.Count; ++i){
            hats[i].SetActive(false);
        }
    }
    void Update()
    {
        debugCorrect = isCorrect;
        if(ok){
          return ;
        }
        if(it == hats.Count){
            if(isCorrect){
                // Change Scene to ??
                correctImage.SetActive(true);
                nextButtonCorrect.SetActive(true);
            }
            else{
                // Start This Scene Again
                // restart scene
                wrongImage.SetActive(true);
                nextButtonWrong.SetActive(true);
            }
            ok = true;
        }
        else if(it != last_iterator){
            hats[it].SetActive(true);
            last_iterator = it;
        }
        
    }
}
