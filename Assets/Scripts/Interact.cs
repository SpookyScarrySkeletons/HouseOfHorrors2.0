using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
	public Transform player;
	public float minUsed;

	private Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		//float y = Mathf.Clamp (rb.rotation.eulerAngles.y, 0, 300);
		//rb.rotation = Quaternion.Euler (rb.rotation.eulerAngles.x, y, rb.rotation.eulerAngles.z);
	
		if (Vector3.Distance (transform.position, player.position) <= minUsed) {
			//Make a use key 
			if (Input.GetKeyDown (KeyCode.E)) {
				anim.SetBool ("isOpen", !anim.GetBool ("isOpen"));
			}
		}
	}
}
