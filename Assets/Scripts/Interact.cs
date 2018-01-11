using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
	public Transform player;
	public float minUsed;
	public Transform monster;
	private Animator anim;
	private bool ranOnce;

	void Start ()
	{
		ranOnce = false;
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Vector3.Distance (transform.position, monster.position) <= minUsed && ranOnce == false) {
			anim.SetBool ("isOpen", !anim.GetBool ("isOpen"));
			ranOnce = true;
		}

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
