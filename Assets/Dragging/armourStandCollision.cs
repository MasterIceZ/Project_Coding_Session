using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armourStandCollision : MonoBehaviour
{
    bool inUsed;
    public List<GameObject> smallHat = new List<GameObject>();
    void OnTriggerStay2D(Collider2D other){
        if(inUsed || other.gameObject.GetComponent<dragUI>().isDragging){
            return ;
        }
        int type = other.gameObject.GetComponent<dragUI>().type;
        if(type < smallHat.Count){
          smallHat[type].SetActive(true);
        }
        inUsed = true;
    }
}
