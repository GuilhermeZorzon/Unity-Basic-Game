using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelWon_Score : MonoBehaviour {

	public Text score;

	void Start () {
		string scenescore = PlayerPrefs.GetString("Score");
		score.text = scenescore;
	}
}
