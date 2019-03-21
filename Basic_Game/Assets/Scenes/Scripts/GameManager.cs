using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool GameHasEnded = false;

	public GameObject completeUI;

	public float RstDelay = 1f;
	
	public void EndGame () {
		if(GameHasEnded == false){

			GameHasEnded = true;
			SceneManager.LoadScene("LevelLost_Menu");
			PlayerPrefs.SetString ("Score", "0");

		}
	}

	public void CompleteLevel () {
		int sceneIndex = PlayerPrefs.GetInt("nextLoadedScene");
		if (sceneIndex != 3) {
			SceneManager.LoadScene("LevelWon_Menu");
		}
		else {
			SceneManager.LoadScene("Credits_Menu");
		}
	}

}
