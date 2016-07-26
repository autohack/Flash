using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// Timer.
/// </summary>
public class timer : MonoBehaviour {

	public static bool game_end;
	public Text counterText;
	public static float seconds , minutes;
	public float total_time;
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		game_end = false;
		counterText = GetComponent<Text> () as Text;
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		if (!game_end) {
			minutes = (int)(Time.time / 60f);   // minutes
			seconds = (int)(Time.time % 60f); 	// seconds
			counterText.text = "Time:"+ minutes.ToString("00") + ":" + seconds.ToString("00"); // showing time
			//Debug.Log ("Run");
		}
	}
}
