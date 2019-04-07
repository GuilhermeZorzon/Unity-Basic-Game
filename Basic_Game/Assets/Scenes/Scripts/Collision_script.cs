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


	void Find () {
		FindObjectOfType<GameManager>().EndGame();
	}
}
