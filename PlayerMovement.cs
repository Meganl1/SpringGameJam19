using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float moveTime;
	int check = 0;

	float horizontal;
	float vertical;

	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxisRaw("Horizontal");
		vertical = Input.GetAxisRaw("Vertical");

	}

	private void FixedUpdate()
	{

				if(Input.GetKeyDown(KeyCode.LeftShift))
				{
					speed +=100;
					check = 1;
				}

				rb.velocity = new Vector2(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime);

				if(check == 1)
				{
					speed -=100;
					check = 0;
				}
	}
}
