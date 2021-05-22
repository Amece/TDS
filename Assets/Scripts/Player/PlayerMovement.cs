using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Vector2 direction;
	private Vector3 position;
	
	void Start()
	{
		position = transform.position;
	}

	void Update () 
	{
		GetInput();
		Move();
	}

	private void Move()
	{
		//   ----  transform.Translate(direction*speed*Time.deltaTime);
		transform.position = position;
	}

	private void GetInput()
	{
		direction = Vector2.zero;

		if (Input.GetKey(KeyCode.W))
		{
			//   ----  direction += Vector2.up;
			position.y += speed*Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A))
		{
			//   ---- direction += Vector2.left;
			position.x -= speed*Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			//   ---- direction += Vector2.down;
			position.y -= speed*Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D))
		{
			//   ---- direction += Vector2.right;
			position.x += speed*Time.deltaTime;
		}
	}
}
