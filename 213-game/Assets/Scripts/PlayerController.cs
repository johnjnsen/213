﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{	

	void FixedUpdate(){
		float moveX = Input.GetAxis ("Vertical");
		float moveZ = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveX, 0.0f, moveZ);
		GetComponent<Rigidbody>().velocity = movement;
        Animation an;
        an = GetComponent<Animation>();
        an.Play();

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);

		}

	}


	
}