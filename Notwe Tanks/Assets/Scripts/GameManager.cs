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
	void OnEnable ()
	{
		Bullet.OnBulletDestroyed += OnBulletDestroyed;
	}

	void OnBulletDestroyed(PlayerEnum playerEnum)
	{
		switch(playerEnum) {
			case PlayerEnum.Player1:
				tank2.AddBullet();
				break;	
			case PlayerEnum.Player2:
				tank1.AddBullet();
				break;
		}
	}
}
