using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Script : MonoBehaviour {

	private float speed = 0.3f;
	private bool magnetOn = false;

	void Update () {
		if(magnetOn == true) {
			Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, 4f);
 
      		for (int i = 0; i < hitColliders.Length; i++) {

          		if (hitColliders[i].tag == "Coin") {
            		Transform coin = hitColliders[i].transform;
              		coin.position = Vector3.MoveTowards(coin.position, gameObject.transform.position, speed);
		  		}
			  
			}
		}
	}
	
	
	void OnTriggerEnter (Collider colliderInfo) {

		if (colliderInfo.gameObject.CompareTag("PowerUpDoubleCoins")){
			PlayerPrefs.SetInt("dbCoins", 1);
			colliderInfo.gameObject.SetActive(false);
			StartCoroutine (doubleCoins());
		}

		else if (colliderInfo.gameObject.CompareTag("PowerUpMagnet")){
			magnetOn = true;
			colliderInfo.gameObject.SetActive(false);
			StartCoroutine (magnetCoins());
		}

	}

	IEnumerator doubleCoins () {
		yield return new WaitForSeconds (5f);
		PlayerPrefs.SetInt("dbCoins", 0);
	}

	IEnumerator magnetCoins () {
		yield return new WaitForSeconds (5f);
		magnetOn = false;
	}
}
