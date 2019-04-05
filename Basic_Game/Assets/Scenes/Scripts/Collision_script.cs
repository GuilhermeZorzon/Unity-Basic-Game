using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_script : MonoBehaviour {

	public PlayerMovement movement;
	public Transform explosion;

	// Used when collision occurs

	void OnCollisionEnter (Collision collisioninfo) {

		if (collisioninfo.gameObject.CompareTag("Obstacle")){
			movement.enabled = false;
			gameObject.SetActive(false);
			PlayerPrefs.SetInt("dbCoins", 0);
			Instantiate (explosion, transform.position, explosion.rotation);
			Invoke ("Find", 0.5f);
		}

	}

	void OnTriggerEnter (Collider colliderInfo) {

		if (colliderInfo.gameObject.CompareTag("PowerUp")){
			PlayerPrefs.SetInt("dbCoins", 1);
			colliderInfo.gameObject.SetActive(false);
			StartCoroutine (doubleCoins());
		}

	}

	IEnumerator doubleCoins () {
		yield return new WaitForSeconds (5f);
		PlayerPrefs.SetInt("dbCoins", 0);
	}

	void Find () {
		FindObjectOfType<GameManager>().EndGame();
	}
}
