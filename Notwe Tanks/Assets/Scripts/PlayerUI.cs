using System.Collections;

using TMPro;

using UnityEngine;

namespace Assets.Scripts
{
	public class PlayerUI : MonoBehaviour
	{
		[Header("UI")]
		[SerializeField] TextMeshProUGUI bulletsText;
		[SerializeField] TextMeshProUGUI livesText;


		[Header("Player")]
		[SerializeField] Tank tank;


		private void OnEnable ()
		{
			tank.OnBulletsChanged += Tank_OnBulletsChanged;
			tank.OnLivesChanged += Tank_OnLivesChanged;
		}

		private void Tank_OnLivesChanged (int lives)
		{
			livesText.text = lives.ToString();
		}

		private void Tank_OnBulletsChanged (int bullets)
		{
			bulletsText.text = bullets.ToString ();
		}
	}
}