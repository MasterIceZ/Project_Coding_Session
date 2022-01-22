using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseItem : MonoBehaviour
{
    public GameObject image, button;
    public void onClick(){
        image.SetActive(true);
        button.SetActive(true);
    }
}
