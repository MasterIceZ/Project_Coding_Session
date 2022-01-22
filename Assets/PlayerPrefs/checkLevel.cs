using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkLevel : MonoBehaviour
{
    public List<GameObject> Locked = new List<GameObject>();
    public List<GameObject> Unlocked = new List<GameObject>();
    void Start()
    {
        int current_level = PlayerPrefs.GetInt("level");
        for(int i=0; i<current_level; i++)
        {
            Locked[i].SetActive(false);
            Unlocked[i].SetActive(true);
        }
    }
}
