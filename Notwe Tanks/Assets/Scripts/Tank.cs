using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
	[SerializeField] PlayerEnum playerEnum;
	[SerializeField] Bullet bulletPrefab;


	[Header("Movement")]
	[SerializeField] float moveSpeed = 1;
	[SerializeField] float rotateSpeed = 1;
	[SerializeField] float cooldownTime = 0.25f;

	public event UnityAction<int> OnLivesChanged;
	public event UnityAction<int> OnBulletsChanged;


	public PlayerEnum GetPlayer => playerEnum;

	const int INITIAL_NUM_BULLETS = 5;

	int numBullets;
	float cooldown = 0;


	private Rigidbody2D rigidbody2;
	private AudioSource audioSource;

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
		audioSource = GetComponent<AudioSource>();
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
			audioSource.Play();
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
		rotateInput = -input.x;
	}

	// InputControl callback
	internal void OnFire ()
	{
		ShootBullet();
	}

	private void Move ()
	{
		rigidbody2.velocity = moveInput * moveSpeed * transform.up;
		rigidbody2.rotation += rotateInput * rotateSpeed;
	}
}

