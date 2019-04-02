using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce;

	private float sidewayForce = 0;
	private float jumpForce = -10;  
    private bool isGrounded = true; 
	private bool controllLocked = false;

	
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


	}

	IEnumerator stopSlide () {
		yield return new WaitForSeconds (0.5f);
		sidewayForce = 0;
		controllLocked = false;
	}

	IEnumerator stopJump () {
		yield return new WaitForSeconds (0.4f);
		jumpForce = -4f;
		isGrounded = true;
	}
     
    /*void OnCollisionEnter(Collision collisioninfo) {
		if(collisioninfo.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
    }
    void OnCollisionExit() {
        isGrounded = false; 
} */

}