using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField] float moveSpeed = 1;


	Vector2 rawInput;



	// Start is called before the first frame update
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		Move()
	}


	/// <summary>
	/// Gets the Move value from InputPlayer
	/// </summary>
	/// <param name="value"></param>
	internal void OnMove (InputValue value)
	{
		rawInput = value.Get<Vector2>();
	}


	/// <summary>
	/// Gets Fire value
	/// </summary>
	/// <param name="value"></param>
	internal void OnFire (InputValue value)
	{
		Debug.Log("OnFire: " + value.ToString());
		bool fire = value.isPressed;
		if (fire) {

		}

		//if( shooter != null ) {
		//	shooter.IsFiring = value.isPressed;
		//}
	}

	void Move ()
	{
		Debug.Log(rawInput.ToString());


		//Vector2 delta = moveSpeed * Time.deltaTime * rawInput;

		//(float minX, float maxX) = (minScreenBounds.x + paddingLeft, maxScreenBounds.x - paddingRight);
		//(float minY, float maxY) = (minScreenBounds.y + paddingBottom, maxScreenBounds.y - paddingTop);

		//Vector2 newPos = new Vector2
		//{
		//	x = Mathf.Clamp(transform.position.x + delta.x, minX, maxX),
		//	y = Mathf.Clamp(transform.position.y + delta.y, minY, maxY)
		//};

		//transform.position = newPos;
	}
}
