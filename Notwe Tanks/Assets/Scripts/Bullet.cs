using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] float speed = 20;
	public int thing;
	private Rigidbody2D myBody;

	public PlayerEnum ShotBy { get; set; }

	public delegate void BulletEvent (PlayerEnum playerEnum);
	public static event BulletEvent OnBulletDestroyed;


	void Awake()
	{
		//called once

		myBody = gameObject.GetComponent<Rigidbody2D>();

	}

	// Start is called before the first frame update
	void Start()
<<<<<<< HEAD
	{
		Destroy(gameObject, 5f);
	}
=======
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void InitBullet(Tank tank)
	{
		//Rigidbody2D tankBody = tank.GetComponent<Rigidbody2D>();

		// set position and rotation to same as tank that shot it
		//myBody.MovePosition(tankBody.position);
		//myBody.MoveRotation(tankBody.rotation);
>>>>>>> main

	// Update is called once per frame
	void Update()
	{
		
	}

	public void InitBullet(Tank tank)
	{
		//Rigidbody2D tankBody = tank.GetComponent<Rigidbody2D>();

		// set position and rotation to same as tank that shot it
		//myBody.MovePosition(tankBody.position);
		//myBody.MoveRotation(tankBody.rotation);

<<<<<<< HEAD

=======
>>>>>>> main
		myBody.velocity = tank.transform.up * speed;
		Debug.Log(transform.forward);
		ShotBy = tank.GetPlayer;
	}


	private void OnTriggerEnter2D (Collider2D collision)
	{
		if (OnBulletDestroyed != null) {
			OnBulletDestroyed(ShotBy);
			// destory this gameojbect
			//Destroy(gameObject);
			Destroy(gameObject);
		}
	}
}
