using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Know_Scene : MonoBehaviour {

	void Start () {

		PlayerPrefs.SetString ("lastLoadedScene", SceneManager.GetActiveScene ().name);
		PlayerPrefs.SetInt ("nextLoadedScene", SceneManager.GetActiveScene ().buildIndex);
        
	}
	
}
