using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

class LevelManager : MonoBehaviour
{
	[SerializeField] float sceneLoadDelay = 1;


	const string
		SETTINGS_MENU = "Settings Menu",
		MAIN_MENU = "Main Menu",
		GAME_SCENE = "Game Scene",
		GAME_OVER = "Game Over";


	public enum SceneEnum
	{
		MainMenu,
		Settings,
		Game,
		GameOver
	}

	public string SceneEnumToString(SceneEnum scene)
	{
		switch (scene) {
			case SceneEnum.MainMenu: return MAIN_MENU;
			case SceneEnum.Settings: return SETTINGS_MENU;
			case SceneEnum.Game: return GAME_SCENE;
			case SceneEnum.GameOver: return GAME_OVER;
			default: return MAIN_MENU;
		}
	}


	public void LoadMainMenu ()
	{
		SceneManager.LoadScene("Main Menu");
	}

	public void LoadSettingsMenu ()
	{
		SceneManager.LoadScene("Settings Menu");
	}

	public void LoadGame ()
	{
		SceneManager.LoadScene("Game Scene");
	}

	public void LoadGameOver ()
	{
		SceneManager.LoadScene("Game Over");
	}

	public void QuitGame ()
	{
		Debug.Log("Quiting Game...");
		Application.Quit();
	}
}
