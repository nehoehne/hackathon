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
		if (transform.position.x > 26)
		{
			pos.x = -25;
		}
		else if (transform.position.x < -26)
		{
			pos.x = 25;
		}
		else if (transform.position.y > 17)
		{
			pos.y = -16;
		}
		else if (transform.position.y < -17)
		{
			pos.y = 16;
		}
		transform.position = pos;
	}
}
