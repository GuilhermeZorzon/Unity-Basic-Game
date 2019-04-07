using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Script : MonoBehaviour {
	
	
	void OnTriggerEnter (Collider colliderInfo) {

		if (colliderInfo.gameObject.CompareTag("PowerUpDoubleCoins")){
			PlayerPrefs.SetInt("dbCoins", 1);
			colliderInfo.gameObject.SetActive(false);
			StartCoroutine (doubleCoins());
		}

		else if (colliderInfo.gameObject.CompareTag("PowerUpMagnet")){
			Debug.Log("Getting those coins");
			colliderInfo.gameObject.SetActive(false);
		}

	}

	IEnumerator doubleCoins () {
		yield return new WaitForSeconds (5f);
		PlayerPrefs.SetInt("dbCoins", 0);
	}
}
