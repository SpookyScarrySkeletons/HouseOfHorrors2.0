using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
	CharacterController characterCollider;
	// Use this for initialization
	void Start ()
	{
		characterCollider = gameObject.GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.LeftControl)) {
			characterCollider.height = .5f;
		} else {
			characterCollider.height = 1.8f;
		}
	}
}