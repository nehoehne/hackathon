using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] float speed = 20;
	[SerializeField] GameObject explosionPrefab;


	private Rigidbody2D myBody;

	public PlayerEnum ShotBy { get; set; }

	public delegate void BulletEvent (PlayerEnum playerEnum);
	public static event BulletEvent OnBulletDestroyed;

	private bool canDamage = false;

	const float MAX_LIFETIME = 10;


	void Awake()
	{
		myBody = gameObject.GetComponent<Rigidbody2D>();
	}

	private void Start ()
	{
		Destroy(gameObject, MAX_LIFETIME);
	}

	private void OnDestroy ()
	{
		OnBulletDestroyed?.Invoke(ShotBy);
		Instantiate(
			explosionPrefab,
			transform.position,
			transform.rotation
		);
	}

	public void InitBullet(Tank tank)
	{
		myBody.velocity = tank.transform.up * speed;
		Debug.Log(transform.forward);
		ShotBy = tank.GetPlayer;
	}


	private void OnTriggerEnter2D (Collider2D collision)
	{
		if( canDamage ) {

			OnBulletDestroyed?.Invoke(ShotBy);
			Destroy(gameObject);
		}
	}
}
