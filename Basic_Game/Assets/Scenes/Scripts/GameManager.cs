using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool GameHasEnded = false;

	public float RstDelay = 1f;
	
	public void EndGame () {
		if(GameHasEnded == false){

			GameHasEnded = true;
			Debug.Log("Game over!");
			Invoke("Restart", RstDelay);

		}
	}

	void Restart () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
