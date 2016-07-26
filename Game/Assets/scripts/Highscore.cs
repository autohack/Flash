using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// High score show.
/// </summary>
public class Highscore : MonoBehaviour {
	public Text highscore;
	public int prescore; 
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		prescore = PlayerPrefs.GetInt ("High Score"); // last saved high score
		if (prescore < UImanager.score) {
			highscore.text = "Highscore is : " + UImanager.score; // new high score
		} else {
			highscore.text = "Highscore is : " + prescore;	// previous high score
		}
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	
	}
}
