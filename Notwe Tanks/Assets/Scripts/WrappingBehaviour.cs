using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrappingBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("YO");
		Vector3 pos = transform.position;
		if (transform.position.x > 80)
		{
			pos.x = -79;
			Debug.Log("Right");
		}
		else if (transform.position.x < -80)
		{
			pos.x = 79;
			Debug.Log("Left");
		}
		else if (transform.position.y > 45)
		{
			pos.y = -44;
			Debug.Log("Top");
		}
		else if (transform.position.y < -45)
		{
			pos.y = 44;
			Debug.Log("Bottom");
		}
		transform.position = pos;
	}
}
