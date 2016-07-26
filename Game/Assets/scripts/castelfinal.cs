using UnityEngine;
using System.Collections;

public class castelfinal : MonoBehaviour {
	
	public GameObject Gameover;
	public GameObject Winner;
	public GameObject Car;
	public timer timescript;
	public UImanager ui;
	public GameObject menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			if (timer.minutes < 1f) {
				ui.gameoverActivated ();
				timer.game_end = true;
				Winner.SetActive (true);
				Car.GetComponent<carmoveinmap> ().enabled = false;
			}
			else
			{
				Gameover.SetActive(true);			
			}
			menu.SetActive (true);

		}
	}
}
