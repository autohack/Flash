using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// UI manager.
/// </summary>
public class UImanager : MonoBehaviour {
	public Text scoretext;
	public static int score; //this is passed to highscore script
	public int highscore; // highscore is maintained
	bool gameover; // for stop updating score
	public Button[] buttons;
	//public GameObject GameOver;
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		gameover = false;
		score = 0;
		InvokeRepeating ("scoreupdate", 1.0f, 0.5f);//for repeating the same function after a time
		//PlayerPrefs.SetInt("High Score",0);
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		scoretext.text = "Score: " + score;     // for showing score 
	}
	/// <summary>
	/// Scoreupdate this instance.
	/// </summary>
	void scoreupdate(){
		if (gameover == false) {

			score += 1;			// updating score by time
		}
	}
	/// <summary>
	/// Gameovers the activated.
	/// </summary>
	public void gameoverActivated(){
		gameover = true;
		if (highscore <= score) {
			PlayerPrefs.SetInt ("High Score", highscore);
		}
	
			//GameOver.SetActive(true);
		 
	}
	/// <summary>
	/// Pause this instance.
	/// </summary>
	public void pause()
	{
		if (Time.timeScale == 1) {
			Time.timeScale = 0;			//if playing
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;			// if pause
		}
	}
	/// <summary>
	/// Play this instance.
	/// </summary>
	public void play(){
		Application.LoadLevel (Application.loadedLevel); // Replay last level
	}
	/// <summary>
	/// Exit this instance.
	/// </summary>
	public void exit(){
		Application.Quit (); // exit
	}
}
