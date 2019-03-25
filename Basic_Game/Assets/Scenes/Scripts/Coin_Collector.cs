using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Collector : MonoBehaviour {
	
	public Transform player;
	public Text score;
	private int scr = 0;

	void OnTriggerEnter (Collider collisioninfo) {
		if (collisioninfo.gameObject.CompareTag("Coin")){
			scr += 1;
			score.text = (scr).ToString();
			collisioninfo.gameObject.SetActive(false);
			PlayerPrefs.SetString ("Score", score.text);
		}
	}
}
