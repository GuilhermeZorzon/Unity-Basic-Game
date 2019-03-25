using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Collector : MonoBehaviour {

	void Start()
    {
        //Output the current screen window width in the console
        Debug.Log("Screen Width : " + Screen.width);
		Debug.Log("Screen Height : " + Screen.height);
    }
	
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
