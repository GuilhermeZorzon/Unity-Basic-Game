using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_script : MonoBehaviour {

	public void QuitGame () {

		Debug.Log("Quit!");
		PlayerPrefs.SetString ("Score", "0");
		Application.Quit();
	}

	public void StartGame () {
		PlayerPrefs.SetString ("Score", "0");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void RestartGame () {
		PlayerPrefs.SetString ("Score", "0");
		SceneManager.LoadScene(0);
	}

	public void RestartLevel () {
		string sceneName = PlayerPrefs.GetString("lastLoadedScene");
		PlayerPrefs.SetString ("Score", "0");
        SceneManager.LoadScene(sceneName);
	}

	public void NextLevel () {
		int sceneIndex = PlayerPrefs.GetInt("nextLoadedScene");
		PlayerPrefs.SetString ("Score", "0");
		SceneManager.LoadScene(sceneIndex + 1);
	}

}
