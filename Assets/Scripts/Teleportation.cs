using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Player;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space)) && playerInRange)
        {
            if(playerInRange == true)
            {
                StartCoroutine(Teleport ());
            }
        }
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds (0.4f);
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);  
    }
    



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}

//https://www.youtube.com/watch?v=Mjw8GGzuwKg