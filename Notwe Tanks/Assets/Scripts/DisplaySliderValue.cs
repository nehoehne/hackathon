using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class DisplaySliderValue : MonoBehaviour
{
	TextMeshProUGUI text; 

    // Start is called before the first frame update
    void Awake()
    {
        text= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnValueChange(float value)
	{
		int i = (int) value;

		text.text = i.ToString();
		//move value to text

	}
}
