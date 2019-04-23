using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour {

	public GameObject pauseMenuUI;

	public void Pause () {   
		pauseMenuUI.SetActive(true);         
        Time.timeScale = 0.0f;
	}

	public void Resume () {
		pauseMenuUI.SetActive(false); 
		Time.timeScale = 1.0f;
	}

	public void RestartPaused () {
		string sceneName = PlayerPrefs.GetString("lastLoadedScene");
		PlayerPrefs.SetString ("Score", "0");
		PlayerPrefs.SetInt("dbCoins", 0);
        SceneManager.LoadScene(sceneName);
		Time.timeScale = 1.0f;
	}

	public void MenuPaused () {
		PlayerPrefs.SetString ("Score", "0");
		PlayerPrefs.SetInt("dbCoins", 0);
		SceneManager.LoadScene(0);
		Time.timeScale = 1.0f;
	}
}
