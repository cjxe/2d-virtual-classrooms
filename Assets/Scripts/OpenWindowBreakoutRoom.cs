using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindowBreakoutRoom : MonoBehaviour
{
    public GameObject Window;
    public GameObject Player;

    public void OpenWindowBR()
    {
        if(Player.transform.position.y > 27){
            if(Window != null)
            {
                bool isActive = Window.activeSelf;

                Window.SetActive(!isActive);
            }
        }
    }
}
// https://www.youtube.com/watch?v=LziIlLB2Kt4