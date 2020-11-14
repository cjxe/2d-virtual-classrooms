using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // make it public so we can change it from the inspector
    private Rigidbody2D myRigidbody; // make a reference to myRigidbody
    private Vector3 change; // how much we want the player's position to change

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed; // if player pushes any of the right/left buttons, update "x" coord
        change.y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        //Debug.Log(change); logs/prints the change
        if (change != Vector3.zero)
        {
            transform.Translate(new Vector3(change.x, change.y));
        }
    }

    /*
    void MoveCharacter() // move the character from other places (i.e buttons on the screen), so we create is as a method
    {
        myRigidbody.MovePosition(transform.position + change.normalized * speed * Time.deltaTime); // grab the pos of the player, add change (x speed) and multiply how much time has passed time has passed since the prev frame
    }
    */
}
