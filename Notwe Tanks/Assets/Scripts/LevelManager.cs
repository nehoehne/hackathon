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


	//public static LevelManager Instance { get; private set; } = null;

	//void Awake ()
	//{
	//	if( Instance == null ) {
	//		Instance = this;
	//		DontDestroyOnLoad(gameObject);
	//	}
	//	else {
	//		gameObject.SetActive(false);
	//		DestroyImmediate(gameObject);
	//	}
	//}

	//public void LoadLevel (SceneEnum scene)
	//{
	//	SceneManager.LoadScene(SceneEnumToString(scene));
	//}

	//public void LoadLevel(string levelName)
	//{
	//	SceneManager.LoadScene(levelName);
	//}




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
		StartCoroutine(WaitAndLoadLevel("Game Over", sceneLoadDelay));
	}

	public void QuitGame ()
	{
		Debug.Log("Quiting Game...");
		Application.Quit();
	}

	public IEnumerator WaitAndLoadLevel (string sceneName, float delay)
	{
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene(sceneName);
	}
}
