using UnityEngine;
using System.Collections;
/// <summary>
/// Music.
/// </summary>
public class Music : MonoBehaviour {
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;

	// Use this for initialization

	
	
	// Update is called once per frame
	/// <summary>
	/// Playing Music by menu.
	/// </summary>
	void Update () {
		if (!audio1.isPlaying && !audio3.isPlaying) {
			audio2.Play ();
		}
		else if (!audio2.isPlaying && !audio1.isPlaying) {
			audio3.Play ();
		}
		else if(!audio3.isPlaying && !audio2.isPlaying){
			audio1.Play();
		}
			
	}
}
