using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public int speed;

	void Update () 
	{
		transform.Translate(Vector2.up * Time.deltaTime * speed);
	}
}
