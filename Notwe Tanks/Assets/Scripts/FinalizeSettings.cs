using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalizeSettings : MonoBehaviour
{
	[SerializeField] Slider startLivesSlider;
	[SerializeField] Slider startBulletsSlider;


    // Start is called before the first frame update
    void Start()
    {
		startLivesSlider.value = GameConfig.StartLives;
		startBulletsSlider.value = GameConfig.StartBullets;
	}

	public void GoAndSave ()
	{
		//set value in game configs from the sliders
		GameConfig.StartLives = (int)startLivesSlider.value;
		GameConfig.StartBullets = (int)startBulletsSlider.value;
		
	}
}
