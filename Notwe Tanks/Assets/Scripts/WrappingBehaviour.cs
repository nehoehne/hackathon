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
		Vector3 pos = transform.position;
		if (transform.position.x > 80)
		{
			pos.x = -79;
		}
		else if (transform.position.x < -80)
		{
			pos.x = 79;
		}
		else if (transform.position.y > 45)
		{
			pos.y = -44;
		}
		else if (transform.position.y < -45)
		{
			pos.y = 44;
		}
		transform.position = pos;
	}
}
