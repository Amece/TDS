using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoose : MonoBehaviour {

	public int class_starter;
	public int class_rifle;
	public int class_sniper;
	public int class_minigun;
	public int class_lasergun;

	public GameObject starter;
	public GameObject rifle;
	public GameObject sniper;
	public GameObject minigun;
	public GameObject lasergun;

	private PlayerFire PlayerFire;

	public GameObject player;


	void Start () 
	{
        PlayerFire = player.GetComponent<PlayerFire>();
		PlayerFire.timeBtwShots = 1f;


		/* ==== reset de variables
		class_starter = 1;
		class_rifle = 0;
		class_sniper = 0;
		class_minigun = 0;
		class_lasergun = 0;*/
	}

	void Update () 
	{
		GetUpdate();
	}

	private void GetUpdate ()
	{
		if (Input.GetKey(KeyCode.Alpha1))
		{
			if (class_starter == 1)
			{
				PlayerFire.timeBtwShots = 1f;

				starter.SetActive(true);
				rifle.SetActive(false);
				sniper.SetActive(false);
				minigun.SetActive(false);
				lasergun.SetActive(false); 
			}
			else
			{
				Debug.Log("ERROR");
			}
		}
		else if (Input.GetKey(KeyCode.Alpha2))
		{
			if (class_rifle == 1)
			{
				PlayerFire.timeBtwShots = 0.2f;

				starter.SetActive(false);
				rifle.SetActive(true);
				sniper.SetActive(false);
				minigun.SetActive(false);
				lasergun.SetActive(false); 
			}
			else
			{
				Debug.Log("Je hebt geen rifle gepakt");
			}
		}
		else if (Input.GetKey(KeyCode.Alpha3))
		{
			if (class_sniper == 1)
			{
				PlayerFire.timeBtwShots = 3f;

				starter.SetActive(false);
				rifle.SetActive(false);
				sniper.SetActive(true);
				minigun.SetActive(false);
				lasergun.SetActive(false); 
			}
			else
			{
				Debug.Log("Je hebt geen sniper gepakt");
			}
		}
		else if (Input.GetKey(KeyCode.Alpha4))
		{
			if (class_minigun == 1)
			{
				PlayerFire.timeBtwShots = 0.05f;

				starter.SetActive(false);
				rifle.SetActive(false);
				sniper.SetActive(false);
				minigun.SetActive(true);
				lasergun.SetActive(false); 
			}
			else
			{
				Debug.Log("Je hebt geen minigun gepakt");
			}
		}
		else if (Input.GetKey(KeyCode.Alpha5))
		{
			if (class_lasergun == 1)
			{
				PlayerFire.timeBtwShots = 1f;

				starter.SetActive(false);
				rifle.SetActive(false);
				sniper.SetActive(false);
				minigun.SetActive(false);
				lasergun.SetActive(true); 
			}
			else
			{
				Debug.Log("Je hebt geen lasergun gepakt");
			}
		}
	}	
}
