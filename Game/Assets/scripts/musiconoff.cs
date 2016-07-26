using UnityEngine;
using System.Collections;
/// <summary>
/// Music on off.
/// </summary>
public class musiconoff : MonoBehaviour {
	public GameObject music;
	// Use this for initialization
	/// <summary>
	/// Raises the  event on click.
	/// </summary>
	public void Onclick () {
		if (!music.activeInHierarchy) {
			music.SetActive (true); //set Music On-Off
		} else {
			music.SetActive (false);
		}
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	
	}
}
