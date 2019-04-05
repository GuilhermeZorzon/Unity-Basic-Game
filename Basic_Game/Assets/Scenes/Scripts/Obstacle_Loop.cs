﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Loop : MonoBehaviour {

	public Transform obstacle;
	public Transform obstacle1Lane;
	public Transform pit;
	public Transform unjumpable;
	public Transform slideUnder;
	public Transform slideUnder2Lane;

	private int frameInterval = 220;
	private float zInterval = 0f;
	private float zFirst = 20f;

	private int gObjDef;
	//private int gObj2Def;

	private Transform gObj;
	//private Transform gObj2;

	private int numObj;
	private int lane;
	//private int lane2;

	private Vector3 objTransformSpecific;
	//private Vector3 objTransformSpecific2;


	void Start () {
        Invoke("Obs", 0);
	}
	
	
	void Update () {
		 if (Time.frameCount % frameInterval == 0) {
			 Invoke("Obs", 0);
		 }
	}

	void Obs () {

		for (int i = 0; i < 9; i++){
			gObjDef = Random.Range(0,6);
			//gObj2Def = Random.Range(0,3);
			//numObj = Random.Range(1,2);
			lane = Random.Range(-1,2);

			PlayerPrefs.SetInt("coinTeller", gObjDef);
			PlayerPrefs.SetInt("coinPlace", lane);


			if (gObjDef == 0) {
				gObj = obstacle;
			}
			else if (gObjDef == 1) {
				gObj = obstacle1Lane;
			}
			else if (gObjDef == 2) {
				gObj = pit;
			}
			else if (gObjDef == 3) {
				gObj = unjumpable;
			}
			else if (gObjDef == 4) {
				gObj = slideUnder;
			}
			else if (gObjDef == 5) {
				gObj = slideUnder2Lane;
			}


			/*if (gObj2Def == 0) {
				gObj2 = obstacle;
			}
			else if (gObj2Def == 1) {
				gObj2 = obstacle1Lane;
			}
			else if (gObj2Def == 2) {
				gObj2 = pit;
			}
			else {
				gObj2 = unjumpable;
			}*/
			
			objTransformSpecific = gObj.position;
			/*if (numObj == 2) {
				objTransformSpecific2 = gObj2;
			}*/
			
			
			Instantiate(gObj, new Vector3(objTransformSpecific.x * lane, objTransformSpecific.y, zFirst + zInterval) ,gObj.rotation);
			/*if (numObj == 2) {
				Instantiate(gObj2, new Vector3(objTransformSpecific2.x * lane2, objTransformSpecific2.y, zFirst + zInterval) ,gObj2.rotation);

			}*/

			PlayerPrefs.SetFloat("zPlace", zFirst + zInterval);

			zInterval = zInterval + 10f;
			
			FindObjectOfType<Coin_Loop>().Coin();
		}

		FindObjectOfType<PowerUp_Loop>().PowerUp();

		zInterval = 0f;
		zFirst = zFirst + 100f;

		Debug.Log("zInterval: " + zInterval);
		Debug.Log("zFirst: " + zFirst);
	}
}
