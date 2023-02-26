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
	[SerializeField] LevelManager levelManager;
	[SerializeField] Tank tank1;
	[SerializeField] Tank tank2;

	public static PlayerEnum? Winner { get; private set; } = PlayerEnum.Player1;

	// Start is called before the first frame update
	void OnEnable ()
	{
		Bullet.OnBulletDestroyed += OnBulletDestroyed;


		tank1.OnLivesChanged += Tank1_OnLivesChanged;
		tank2.OnLivesChanged += Tank2_OnLivesChanged;
	}

	private void Tank2_OnLivesChanged (int lives)
	{
		if (lives == 0) {
			Winner = PlayerEnum.Player1;
			levelManager.LoadGameOver();
		}
	}

	private void Tank1_OnLivesChanged (int lives)
	{
		if( lives == 0 ) {
			Winner = PlayerEnum.Player2;
			levelManager.LoadGameOver();
		}
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
