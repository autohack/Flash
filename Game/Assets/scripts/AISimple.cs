using UnityEngine;
using System.Collections;

public class AISimple : MonoBehaviour {

	float Distance;
	public Transform Target;
	public float movespeed = 120;
	public float Damping = 6.0f;
	public float rotspeed;

	void Update () {
		Distance = Vector3.Distance (Target.position, transform.position);
		//lookat ();
		//rotate the car 
		Quaternion rot = transform.rotation;

		float z = rot.eulerAngles.z;

		z -= Input.GetAxis ("Horizontal") * rotspeed * Time.deltaTime;
		rot = Quaternion.Euler (0, 0, z);
		transform.rotation = rot;

		attack ();
	}

	void lookat () {
		var rotation = Quaternion.LookRotation (Target.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * Damping);
	}

	void attack () {
		transform.position = Vector3.MoveTowards(transform.position, Target.position, movespeed*Time.deltaTime);
	}
}
