using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{

	UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;
	public GameObject character;
	public GameObject monster;
	public Camera deathCam;
	float speed = 5;
	bool active;
	public Light myLight;

	void Start ()
	{
		controller = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ();

	}

	IEnumerator HitCam ()
	{
		yield return new WaitForSeconds (.867f);
		active = false;
		Camera.main.gameObject.SetActive (false);
		deathCam.gameObject.SetActive (true);
		yield return new WaitForSeconds (.867f);
		deathCam.gameObject.SetActive (false);
	
	}

	public void Attacked ()
	{
		//myLight.spotAngle = 90;
		print ("rawr XD");
		controller.enabled = false;
		active = true;
		StartCoroutine (HitCam ());
	}

	void Look (Vector3 target)
	{

		Vector3 targetDir = target - (transform.position + new Vector3 (0, .1f));
		//targetDir.y = 0.0f;
		transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (targetDir), Time.time * speed);

	}

	//	void Move (Vector3 target)
	//	{
	//		float x = transform.position.x;
	//		float z = transform.position.z;
	//		transform.position = new Vector3 (x, 0.5f, z);
	//
	//	}

	void Update ()
	{
		if (active) {
			Look (monster.transform.position + (new Vector3 (0, 1f, 0)));
			//Move ((new Vector3 (0, -4.3f, 0)));
		}
	}
	//Fucking do something about this conner
}
