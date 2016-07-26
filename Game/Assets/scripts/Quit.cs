using UnityEngine;
using System.Collections;
/// <summary>
/// for Quit.
/// </summary>
public class Quit : MonoBehaviour {

	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update(){
		if (Input.GetKey("escape")) // esc key to stop the game
			Application.Quit();
	}
	/// <summary>
	/// Raises the click event.
	/// </summary>
	public void OnClick () {
		Application.Quit();  // stopping the game on click
	}
}
