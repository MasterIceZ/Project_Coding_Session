using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragUI_forScene2 : MonoBehaviour
{
    private bool isDragging;
    void Start()
    {
        isDragging = false;
    }
    void Update()
    {
        if (isDragging)
        {
            transform.position = Input.mousePosition;
        }   
    }
    public void startDrag()
    {
        isDragging = true;
    }
    public void endDrag()
    {
        isDragging = false;
    }
}
