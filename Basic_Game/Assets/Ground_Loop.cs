using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Loop : MonoBehaviour {

	public Transform grd;
	public GameObject ply;

	public Transform plyTransform;

	private float zGdPos = 145;
	private int interval = 30;
	

	void Update()
	{
	    if (Time.frameCount % interval == 0)
	    {
	        Instantiate(grd, new Vector3(0, 0, zGdPos) ,grd.rotation);
			zGdPos = zGdPos + 100;
			Debug.Log(plyTransform.position);
	    }
	}
}
