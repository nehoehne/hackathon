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

	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnBulletDestroyed(PlayerEnum playerEnum)
	{

	}



}
