using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowBreakoutRoom : MonoBehaviour
{
    public GameObject Window;

    public void OpenWindowBR()
    {
        if(Window != null)
        {
            bool isActive = Window.activeSelf;

            Window.SetActive(!isActive);
        }
    }
}

// https://www.youtube.com/watch?v=LziIlLB2Kt4