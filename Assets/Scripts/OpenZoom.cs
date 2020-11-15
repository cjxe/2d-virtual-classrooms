using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OpenZoom : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenApplication()
    {
        if(Player.transform.position.y > 27){
            System.Diagnostics.Process.Start("C:\\Users\\mbara\\AppData\\Roaming\\Zoom\\bin\\Zoom.exe");
            // Credit to mert can celik
        }
    }
}
