using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_script : MonoBehaviour {

	public PlayerMovement movement;

	// Used when collision occurs

	void OnCollisionEnter (Collision collisioninfo) {

		if (collisioninfo.gameObject.CompareTag("Obstacle")){
			movement.enabled = false;
		}

	}
}
