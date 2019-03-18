using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;

	public float sidewayForce = 500f;

	void Start () {
		
	}
	
	// Update is called once per frame. FixedUpdate is because of Physics
	void FixedUpdate () {
		
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if( Input.GetKey("d") ){

			rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		else if ( Input.GetKey("a") ){
			
			rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}