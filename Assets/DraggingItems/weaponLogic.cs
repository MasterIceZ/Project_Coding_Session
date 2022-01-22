using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponLogic : MonoBehaviour
{
    public GameObject Side;
    public bool correct = false;
    public bool onField = false;
    private void OnTriggerStay2D(Collider2D other){
        if(other.tag == "Rack"){
            correct = (other.gameObject == Side);
            onField = true;
        }
    }
}
