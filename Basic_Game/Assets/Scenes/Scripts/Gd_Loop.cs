using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gd_Loop : MonoBehaviour {

	public Transform grd;
	public GameObject ply;

	public Transform plyTransform;

	private float zGdPos = 145;
	private int interval = 220;

	/*void Start () {
        InvokeRepeating("Gdr", 4f, 2f);
	}*/

	void Update () {
	    if (Time.frameCount % interval == 0) {
	        Instantiate(grd, new Vector3(0, 0, zGdPos) ,grd.rotation);
			zGdPos = zGdPos + 100;
			Debug.Log("Pos: " + plyTransform.position);
	    }
	}

	void Gdr () {
		Instantiate(grd, new Vector3(0, 0, zGdPos) ,grd.rotation);
		zGdPos = zGdPos + 100;
		Debug.Log("Pos: " + plyTransform.position);
	}
}
