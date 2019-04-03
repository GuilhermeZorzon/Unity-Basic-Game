using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Loop : MonoBehaviour {

	public Transform coin1;
	public Transform coinStraight;
	public Transform coinJump;

	private int coinTell;
	private int lane;
	private float zUsed;
	private Transform coinUsed;
	private Vector3 objTransformSpecific;


	public void Coin () {
		coinTell = PlayerPrefs.GetInt("coinTeller");
		lane =  PlayerPrefs.GetInt("coinPlace");
		zUsed = PlayerPrefs.GetFloat("zPlace");
		
		if (coinTell == 0) {
			coinUsed = coinJump;
		}
		else if (coinTell == 1 || coinTell == 3 || coinTell == 2) {
			coinUsed = coin1;
			while (lane == PlayerPrefs.GetInt("coinPlace")){
				lane = Random.Range(-1, 2);
			}
		}
		else if (coinTell == 4 || coinTell == 5) {
			coinUsed = coinStraight;
		}

			
		objTransformSpecific = coinUsed.position;
		
			
		Instantiate(coinUsed, new Vector3(2 * lane, objTransformSpecific.y, zUsed) ,coinUsed.rotation);
	}
}
