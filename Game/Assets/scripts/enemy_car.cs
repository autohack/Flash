using UnityEngine;
using System.Collections;
/// <summary>
/// Enemy_car movement .
/// </summary>
public class enemy_car : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime); // get translate 
	}
}
