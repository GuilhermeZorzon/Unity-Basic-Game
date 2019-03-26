using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_script : MonoBehaviour {

	public PlayerMovement movement;
	public Transform exp;

	// Used when collision occurs

	void OnCollisionEnter (Collision collisioninfo) {

		if (collisioninfo.gameObject.CompareTag("Obstacle")){
			movement.enabled = false;
			gameObject.SetActive(false);
			Instantiate (exp, transform.position, exp.rotation);
			Invoke ("Find", 0.5f);
		}

	}

	void Find () {
		FindObjectOfType<GameManager>().EndGame();
	}
}
