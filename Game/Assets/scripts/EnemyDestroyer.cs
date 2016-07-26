using UnityEngine;
using System.Collections;
/// <summary>
/// Enemy destroyer.
/// </summary>
public class EnemyDestroyer : MonoBehaviour {

	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
	
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {

	
	}
	//for destroying enemy car after track 
	/// <summary>
	/// Raises the collision enter2 d event.
	/// </summary>
	/// <param name="col">Collision destroyer.</param>
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy Car") {   
			Destroy (col.gameObject);    // destroy enemy 
		}
	}
}
