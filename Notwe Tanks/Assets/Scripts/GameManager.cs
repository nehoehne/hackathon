using System.Collections;
using System.Collections.Generic;

using Assets.Scripts;

using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GameManager : MonoBehaviour
{
	//Dictionary<PlayerEnum, Tank> 

	[SerializeField] Tank tank1;
	[SerializeField] Tank tank2;

	// Start is called before the first frame update
	void Start ()
	{
		Bullet.OnBulletDestroyed += Bullet_OnBulletDestroyed;
	}

	private void Bullet_OnBulletDestroyed (PlayerEnum playerEnum)
	{
		
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnBulletDestroyed(PlayerEnum playerEnum)
	{
		switch(playerEnum) {
			case PlayerEnum.Player1:
				// incease player2 bullet by calling method in Tank
				break;
				// opposite thing in other case.
		}
	}



}
