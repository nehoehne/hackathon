using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
	[SerializeField] float moveSpeed = 1;

	[Header("Confinement Padding")]
	[SerializeField] float paddingLeft = 0.5f;
	[SerializeField] float paddingRight = 0.5f;
	[SerializeField] float paddingTop = 0.5f;
	[SerializeField] float paddingBottom = 0.5f;

	Shooter shooter;

	Vector2 rawInput;
	Vector2 minScreenBounds;
	Vector2 maxScreenBounds;

	public static Player Instance { get; private set; }

	void Awake()
	{
		shooter = GetComponent<Shooter>();
		Instance = this;
	}

	void Start()
	{
		InitBounds();
	}

	void OnDestroy()
	{
		Instance = null;
	}

	void Update()
	{
		Move();
	}

	void InitBounds()
	{
		Camera mainCamera = Camera.main;

		//Vector3 bottomLeftPadding = new Vector2(paddingLeft, paddingBottom);
		//Vector3 topRightPadding = new Vector2(paddingRight, paddingTop);

		minScreenBounds = mainCamera.ViewportToWorldPoint(Vector2.zero);// + bottomLeftPadding;
		maxScreenBounds = mainCamera.ViewportToWorldPoint(Vector2.one);// - topRightPadding;
	}

	internal void OnMove(InputValue value)
	{
		rawInput = value.Get<Vector2>();
	}

	internal void OnFire(InputValue value)
	{
		if (shooter != null)
		{
			shooter.IsFiring = value.isPressed;
		}
	}

	void Move()
	{
		Vector2 delta = moveSpeed * Time.deltaTime * rawInput;

		(float minX, float maxX) = (minScreenBounds.x + paddingLeft, maxScreenBounds.x - paddingRight);
		(float minY, float maxY) = (minScreenBounds.y + paddingBottom, maxScreenBounds.y - paddingTop);

		Vector2 newPos = new Vector2 {
			x = Mathf.Clamp(transform.position.x + delta.x, minX, maxX),
			y = Mathf.Clamp(transform.position.y + delta.y, minY, maxY)
		};

		transform.position = newPos;
	}
}
