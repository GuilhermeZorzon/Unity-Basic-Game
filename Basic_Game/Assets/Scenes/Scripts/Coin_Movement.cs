﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Movement : MonoBehaviour {

	public float speed;
    
    
    void Update ()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
		
	}
}
