using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;

public class Tank : MonoBehaviour
{
	[SerializeField] PlayerEnum playerEnum;
	[SerializeField] Bullet bulletPrefab;

	public PlayerEnum GetPlayer => playerEnum;

	const int INITIAL_NUM_BULLETS = 5;

	int numBullets;

	// Start is called before the first frame update
	void Start ()
	{
		numBullets = INITIAL_NUM_BULLETS;
	}

	private float i = 0;

	// Update is called once per frame
	void Update ()
	{
		i++;
		if( i% 10 == 0 ) {
			ShootBullet();
		}
	}

	public void ShootBullet()
	{
		// add logic
		/**
		 * only shoot if bullets > 0
		 * decrease bullets when we shoot
		 */
		if( numBullets > 0 ) {
			Instantiate(
					bulletPrefab,
					transform.position,
					transform.rotation
				).InitBullet(this);
			
			numBullets--;
		}
		
		
	}

	// add method that increments bullets by 1

	public void AddBullet()
	{
		numBullets++;
	}
}
