using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Collector : MonoBehaviour {
	
	public Transform player;
	public Text score;

	// Update is called once per frame
	void Update () {
		if(player.position.z >= 25.5)
		score.text = (player.position.z - 25).ToString("0");
	}
}
