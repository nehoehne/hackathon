using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class WinnerText : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI text;

	private void Awake ()
	{
		text.text = $"{GameManager.Winner.ToString()} Wins!!!";
	}
}
