using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Loop : MonoBehaviour {

	public Transform PUpDouble;
	public Transform PUpMagnet;

	private Vector3 objTransformSpecific;
	private Transform PUp;
	private int PUpChoice;

	public void PowerUp () {

		PUpChoice = Random.Range(0, 2);

		if (PUpChoice == 0) {
			PUp = PUpDouble;
		}
		else {
			PUp = PUpMagnet;
		}

		objTransformSpecific = PUp.position;

		Instantiate(PUp, new Vector3(objTransformSpecific.x * Random.Range(-1,2), objTransformSpecific.y, PlayerPrefs.GetFloat("zPlace") + 15f) ,PUp.rotation);
	}
}
