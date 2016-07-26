using UnityEngine;
using System.Collections;
/// <summary>
/// Win collider .
/// </summary>
public class win : MonoBehaviour {
	public GameObject Gameover;
	public GameObject Winner;
	public GameObject Car;
	public GameObject enemy;
	//public carmoveinmap carmove;
	public UImanager ui;
	public timer timescript;
	public GameObject menu;
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		//carmove = GetComponent<carmoveinmap> ();  // Get script component
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		
		
	}
	/// <summary>
	/// Raises the collision enter2 d event.
	/// </summary>
	/// <param name="col">Collider .</param>
	void OnCollisionEnter2D(Collision2D col) {
		Debug.Log("Hi");
		//Debug.Log (col.gameObject.tag);
		if (col.gameObject.tag == "Player") 
		{
			//Debug.Log("Hi");
			ui.gameoverActivated();
			timer.game_end = true;
			Winner.SetActive(true);	//print Win

			Car.GetComponent<carmoveinmap>().enabled = false;  // stop script 
			//xolo = GetComponent(carmoveinmap);
			//carmove.enabled = false;
			//Application.LoadLevel("main");
		}
		if (col.gameObject.tag == "Enemy Car") 
		{
			Gameover.SetActive(true);		 // print Lose
			enemy.GetComponent<Seeker>().enabled = false;		 // stop script
			enemy.GetComponent<EnemyAI>().enabled = false;		 // stop script
		}	

		menu.SetActive (true);
}
}
