using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour {

	public Rigidbody rb;
	public float jumpforce;  
    private bool isgrounded; 
         
    void Update () { 
 
        if(Input.GetKeyDown(KeyCode.Space) && isgrounded) {
            rb.AddForce(Vector3.up*jumpforce);
        }
    }
     
    void OnCollisionEnter(Collision collisioninfo) {
		if(collisioninfo.gameObject.CompareTag("Ground")){
			isgrounded = true;
		}
    }
    void OnCollisionExit() {
        isgrounded = false;
    } 

}
