using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

	//   ---- Starter Class ----
	public GameObject class_starter;
	public GameObject bullet_starter;
	public Transform bullet_starterSpawn;
	//   ---- Rifle Class ----
	public GameObject class_rifle;
	public GameObject bullet_rifle;
	public Transform bullet_rifleSpawn;

	//   ---- Minigun Class ---- 

	public GameObject class_minigun;
	public GameObject bullet_minigun;
	public Transform bullet_minigunSpawn;

	//   ---- Sniper Class ---- 

	public GameObject class_sniper;
	public GameObject bullet_sniper;
	public Transform bullet_sniperSpawn;

	//   ---- Lasergun Class ---- 

	public GameObject class_lasergun;
	public GameObject bullet_lasergun;
	public Transform bullet_lasergunSpawn;


	//   ---- Variables die veranderen ---- 
	private GameObject bullet;
	private Transform bulletSpawn;

	public float timeBtwShots;

	public float lastShot;

	void Update()
	{
		if (Input.GetMouseButton(0) && Time.time - lastShot >= timeBtwShots)
		{
			lastShot = Time.time;
			checkFire();
		}
		
	}

	public void checkFire()
	{
		//   ==== Als starter actief is  ====
		if (class_starter.activeSelf)
		{
			bullet = bullet_starter;
			bulletSpawn = bullet_starterSpawn;
			Fire();
		}
		//   ==== Als rifle actief is  ====
		else if (class_rifle.activeSelf)
		{
			bullet = bullet_rifle;
			bulletSpawn = bullet_rifleSpawn;
			Fire();
		}
		//   ==== Als minigun actief is  ====
		else if (class_minigun.activeSelf)
		{
			bullet = bullet_minigun;
			bulletSpawn = bullet_minigunSpawn;
			Fire();
		}
		//   ==== Als sniper actief is  ====
		else if (class_sniper.activeSelf)
		{
			bullet = bullet_sniper;
			bulletSpawn = bullet_sniperSpawn;
			Fire();
		}
		//   ==== Als lasergun actief is  ====
		else if (class_lasergun.activeSelf)
		{
			bullet = bullet_lasergun;
			bulletSpawn = bullet_lasergunSpawn;
			Fire();
		}
	}

	public void Fire()
	{
		GameObject bulletOBJ = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
		Destroy(bulletOBJ, 1.5f);
	}
}
