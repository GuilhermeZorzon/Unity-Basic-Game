using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_script : MonoBehaviour {

	public void QuitGame () {

		Debug.Log("Quit!");
		Application.Quit();
	}

	public void StartGame () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void RestartGame () {
		SceneManager.LoadScene(0);
	}

	public void RestartLevel () {
		string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        SceneManager.LoadScene(sceneName);
	}

}
