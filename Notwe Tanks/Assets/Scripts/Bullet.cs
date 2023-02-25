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
		myBody = gameObject.GetComponent<Rigidbody2D>();
	}

	// Start is called before the first frame update
	void Start()
	{
		Destroy(gameObject, 5f);
	}

	public void InitBullet(Tank tank)
	{
		myBody.velocity = tank.transform.up * speed;
		Debug.Log(transform.forward);
		ShotBy = tank.GetPlayer;
	}


	private void OnTriggerEnter2D (Collider2D collision)
	{
		if (OnBulletDestroyed != null) {
			OnBulletDestroyed(ShotBy);
			Destroy(gameObject);
		}
	}
}
