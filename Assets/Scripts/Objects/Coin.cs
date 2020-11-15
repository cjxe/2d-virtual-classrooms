using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Powerup
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //playerInventory.coins += 1;
            //powerupSignal.Raise();
            Destroy(this.gameObject);
        }
    }
}
