using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {


	public int health;

	public GameObject HP1;
	public GameObject HP2;
	public GameObject HP3;
	public GameObject HP4;
	public GameObject HP5;



	// Use this for initialization
	void Start () 
	{
		health = 5;
		//health = PlayerPrefs.GetInt("playerHealth");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "enemy0" || other.tag == "enemy_bullet0" || 
			other.tag == "enemy1" || other.tag == "enemy_bullet1")
		{
			health = health - 1;
		}
		else if (other.tag == "enemy0" || other.tag == "enemy_bullet0")
		{
			
		}
	}
}
