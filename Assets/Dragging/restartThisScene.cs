using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartThisScene : MonoBehaviour
{
    public void onClick(){
        Application.LoadLevel(Application.loadedLevel);
    }
}
