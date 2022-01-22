using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideLogic : MonoBehaviour
{
    public static bool correct;
    private bool ok;
    public List<GameObject> objects;
    public int current, last;
    public GameObject correctImage, wrongImage, correctButton, wrongButton;
    void Start()
    {
        current = 0;
        last = -1;
        ok = false;
        correct = true;
        objects[0].SetActive(true);
        for(int i=1; i<objects.Count; i++){
            objects[i].SetActive(false);
        }
    }
    void Update(){
        if(objects[current].GetComponent<weaponLogic>().onField && current + 1 < objects.Count){
            current += 1;
            last = current;
            objects[current].SetActive(true);
        }
        if(!startChecking.checking || ok){
            return ;
        }
        correct = true;
        for(int i=0; i<objects.Count; i++){
            Debug.Log(objects[i].GetComponent<weaponLogic>().correct);
            if(objects[i].GetComponent<weaponLogic>().correct != true){
                correct = false;
                break;
            }
        }
        if(correct){
            Debug.Log("Correct");
            correctImage.SetActive(true);
            correctButton.SetActive(true);
        }
        else{
            Debug.Log("Wrong");
            wrongImage.SetActive(true);
            wrongButton.SetActive(true);
        }
        ok = true;
    }
}
