using UnityEngine;
using System.Collections;
/// <summary>
/// Camera controll.
/// </summary>
public class camercontroll : MonoBehaviour {

	public GameObject Car; //gameobject for following 
	private Vector3 offset;
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		offset = transform.position - Car.transform.position;   // change position according to car
	
	}
	
	// Update is called once per frame
	/// <summary>
	/// the update once per frame.
	/// </summary>
	void LateUpdate () {
		transform.position = Car.transform.position + offset; // Update position
	}
}
