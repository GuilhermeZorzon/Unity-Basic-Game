using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Loop : MonoBehaviour {

	public Transform PUp;

	private Vector3 objTransformSpecific;

	public void PowerUp () {

		objTransformSpecific = PUp.position;

		Instantiate(PUp, new Vector3(objTransformSpecific.x * Random.Range(-1,2), objTransformSpecific.y, PlayerPrefs.GetFloat("zPlace") + 15f) ,PUp.rotation);
	}
}
