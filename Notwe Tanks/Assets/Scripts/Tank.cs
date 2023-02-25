using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
	[SerializeField] PlayerEnum playerEnum;
	[SerializeField] Bullet bulletPrefab;


	[Header("Movement")]
	[SerializeField] float moveSpeed = 1;
	[SerializeField] float rotateSpeed = 1;
	[SerializeField] float cooldownTime = 2f;

	

	public PlayerEnum GetPlayer => playerEnum;

	const int INITIAL_NUM_BULLETS = 5;

	int numBullets;
	float cooldown = 0;


	private Rigidbody2D rigidbody2;

	float moveInput;
	float rotateInput;


	private void Awake ()
	{
		rigidbody2 = GetComponent<Rigidbody2D>();
	}

	// Start is called before the first frame update
	void Start ()
	{
		numBullets = INITIAL_NUM_BULLETS;
	}

	private float i = 0;

	// Update is called once per frame
	void Update ()
	{
		cooldown -= Time.deltaTime;

		Move();
	}


	public void ShootBullet()
	{
		// add logic
		/**
		 * only shoot if bullets > 0
		 * decrease bullets when we shoot
		 */
		if( numBullets > 0 && cooldown < 0 ) {
			Instantiate(
					bulletPrefab,
					transform.position,
					transform.rotation
				).InitBullet(this);
			
			numBullets--;
			cooldown = cooldownTime;
		}
	}

	// add method that increments bullets by 1

	public void AddBullet()
	{
		numBullets++;
	}


	// InputControl callback
	internal void OnMove (InputValue value)
	{
		var input = value.Get<Vector2>();



		moveInput = input.y;
		rotateInput = input.x;

		Debug.Log($"{nameof(moveInput)}:{moveInput}");
		Debug.Log($"{nameof(rotateInput)}:{rotateInput}");
	}

	// InputControl callback
	internal void OnFire (InputValue value)
	{
		Debug.Log("OnFire: " + value.ToString());
		if( value.isPressed) {
			ShootBullet();
		}
	}

	private void Move ()
	{
		rigidbody2.velocity = moveInput * moveSpeed * transform.up;
		rigidbody2.rotation += rotateInput * rotateSpeed;
	}
}

