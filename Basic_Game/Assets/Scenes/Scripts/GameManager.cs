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
			// Invoke("Restart", RstDelay);

		}
	}

	/*void Restart (float currentScene) {
		SceneManager.LoadScene("Level01");
	}*/

	public void CompleteLevel () {
		completeUI.SetActive(true);
	}

}
