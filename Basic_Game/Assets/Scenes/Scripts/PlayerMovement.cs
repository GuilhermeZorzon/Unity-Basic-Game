﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform plyTransform;

	public float forwardForce;

	private float sidewayForce = 0;
	private float jumpForce = -10;  
    private bool isGrounded = true; 
	private bool controllLocked = false;
	private bool scaleLocked = false;

	
	// Update is called once per frame. FixedUpdate is because of Physics
	void FixedUpdate () {

		rb.velocity = new Vector3 (sidewayForce, jumpForce, forwardForce);

		if( Input.GetKey("d") && controllLocked == false){

			sidewayForce = 3f;
			controllLocked = true;
			StartCoroutine (stopSlide());
		}

		if( Input.GetKey("a") && controllLocked == false){

			sidewayForce = -3f;
			controllLocked = true;
			StartCoroutine (stopSlide());
		}

		
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            jumpForce = +5;
			isGrounded = false;
			StartCoroutine (stopJump());
        }

		if(rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}

		if(Input.GetKeyDown(KeyCode.LeftShift)) {
			plyTransform.localScale = new Vector3(1F, 0.5F, 1F);
			scaleLocked = true;
			StartCoroutine (stopScale());
        }


	}

	IEnumerator stopSlide () {
		yield return new WaitForSeconds (0.5f);
		sidewayForce = 0;
		controllLocked = false;
	}

	IEnumerator stopScale () {
		yield return new WaitForSeconds (0.5f);
		plyTransform.localScale = new Vector3(1F, 1F, 1F);
		scaleLocked = false;
	}

	IEnumerator stopJump () {
		yield return new WaitForSeconds (0.4f);
		jumpForce = -4f;
	}
     
    void OnCollisionEnter(Collision collisioninfo) {
		if(collisioninfo.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
    }
  
}