using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player; 
	private Vector3 offset;

	public float ypos;
	public float zpos;

	// Update is called once per frame
	void Update () {
		offset.z = player.position.z + zpos;
		offset.y = ypos;
		offset.x = transform.position.x;

		transform.position = offset;
		
	}
}
