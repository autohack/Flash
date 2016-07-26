﻿using UnityEngine;
using System.Collections;
/// <summary>
/// Car Controll in map.
/// </summary>
public class carmoveinmap : MonoBehaviour
{
	public float maxspeed;
	// speed
	public float rotspeed;
	// rotation speed
	//public static float timer; // for time show
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start ()
	{
	}
	/// <summary>
	/// Update this instance per frame.
	/// </summary>
	void Update ()
	{
		//rotate the car 
		Quaternion rot = transform.rotation;

		float z = rot.eulerAngles.z;
	
		z -= Input.GetAxis ("Horizontal") * rotspeed * Time.deltaTime;
		rot = Quaternion.Euler (0, 0, z);
		transform.rotation = rot;

		//move the car
		Vector3 pos = transform.position;

		if (Input.GetButtonDown ("Fire1")) {   // fire1 = left ctrl 

			Vector3 velocity = new Vector3 (0, -Input.GetAxis ("Vertical") * 5 * maxspeed * Time.deltaTime, 0);    // boost up by 2
			pos += rot * velocity;
			transform.position = pos;
		} else {
			Vector3 velocity = new Vector3 (0, -Input.GetAxis ("Vertical") * maxspeed * Time.deltaTime, 0);   // normal speed
			pos += rot * velocity;
			transform.position = pos;
		}

	

	}
	/// <summary>
	/// Raises the collision enter2 d event.
	/// </summary>
	/// <param name="col">Collider.</param>
	void OnCollisionEnter2D (Collision2D col)
	{    // on collision 

		if (col.gameObject.tag == "boostup") {
			Destroy (col.gameObject);
			maxspeed = maxspeed * 1.3f;
		}
		if (col.gameObject.tag == "downspeed") {
			Destroy (col.gameObject);
			maxspeed = maxspeed * 0.8f;
		}
	}

	/*void OnGUI(){
		int minutes = Mathf.FloorToInt (timer / 60f);
		int seconds = Mathf.FloorToInt (timer - minutes * 60);
		string nicetime = string.Format ("{0:0}:{1:00}", minutes, seconds);
	
		GUI.Label (new Rect (10, 10, 250, 100), nicetime);
	}*/
}