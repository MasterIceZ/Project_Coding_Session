// Required Event Trigger

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragUI : MonoBehaviour
{
    public bool isDragging; // ??
    bool inUsed;
    public int type;
    
    public List<GameObject> expectedGameObject = new List<GameObject>();
    void Start(){
        isDragging = false;
        inUsed = false;
    }
    void Update(){
        if(isDragging){
//          Touch touch = Input.GetTouch(0);
//          transform.position = touch.position;
            transform.position = Input.mousePosition; // Not sure this will work on Phone
        }
    }
    public void startDrag(){
        if(inUsed){
            isDragging = false;
        }
        isDragging = true;
    }
    public void endDrag(){
        isDragging = false;
    }
    bool checkCorrect(GameObject now){
        for(int i = 0; i < expectedGameObject.Count; ++i){
            if(now == expectedGameObject[i]){
                return true;
            }
        }
        return false;
    }
    void OnTriggerStay2D(Collider2D other){
        if(inUsed || isDragging){
            return ;
        }
        hatHandler.isCorrect &= checkCorrect(other.gameObject);
        gameObject.SetActive(false);
        inUsed = true;
        hatHandler.it++;
    }

}