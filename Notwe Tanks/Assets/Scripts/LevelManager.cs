using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

class LevelManager : MonoBehaviour
{
	//[SerializeField] float sceneLoadDelay = 1;


	//public static LevelManager Instance { get; private set; } = null;

	//void Awake()
	//{
	//	if( Instance == null )
	//	{
	//		Instance = this;
	//		DontDestroyOnLoad(gameObject);
	//	}
	//	else
	//	{
	//		gameObject.SetActive(false);
	//		DestroyImmediate(gameObject);
	//	}
	//}


	//public void LoadMainMenu()
	//{
	//	SceneManager.LoadScene("0 Main Menu");
	//}

	//public void LoadGame()
	//{
	//	ScoreKeeper.ResetScore();
	//	SceneManager.LoadScene("1 Game");
	//}

	//public void LoadGameOver()
	//{
	//	StartCoroutine(WaitAndLoadLevel("2 Game Over", sceneLoadDelay));
	//}

	//public void QuitGame()
	//{
	//	Debug.Log("Quiting Game...");
	//	Application.Quit();
	//}

	//public IEnumerator WaitAndLoadLevel(string sceneName, float delay)
	//{
	//	yield return new WaitForSeconds(delay);
	//	SceneManager.LoadScene(sceneName);
	//}
}
