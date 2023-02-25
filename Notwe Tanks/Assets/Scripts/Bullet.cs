using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;

public class Bullet : MonoBehaviour
{
	public PlayerEnum ShotBy { get; set; }

	public delegate void BulletEvent (PlayerEnum playerEnum);
	public static event BulletEvent OnBulletDestroyed;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }






	private void OnTriggerEnter2D (Collider2D collision)
	{
		if (OnBulletDestroyed != null) {
			OnBulletDestroyed(ShotBy);
		}
	}
}
