using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Animator anim = GetComponent<Animator>();
		AnimatorClipInfo info = anim.GetCurrentAnimatorClipInfo(0)[0];
		Destroy(gameObject, info.clip.averageDuration);
	}
}
