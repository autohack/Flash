using UnityEngine;
using System.Collections;
/// <summary>
/// Change_obj for scene.
/// </summary>
public class change_obj : MonoBehaviour {
	public GameObject Object1;  // object to be stopped
	public GameObject Object2;  // object to be started
	// Use this for initialization
	/// <summary>
	/// Raises the  event on Click.
	/// </summary>
	public void Onclick() {
		Object1.SetActive (false); // stopped object1
		Object2.SetActive (true);  // stopped object2
	}
	

}
