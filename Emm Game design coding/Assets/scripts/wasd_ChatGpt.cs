using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd_ChatGpt : MonoBehaviour
{
    //Variables
    public float movespeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;



    // Start is called before the first frame update
    void Start()
    {
        //Find Rigidbody on this script
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get input from WASD keys
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        movement = new Vector2(moveX, moveY).normalized;
    
    }
	//Find update is called on a fixed value of frames
	private void FixedUpdate()
	{
        //move the player
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
	}
}


