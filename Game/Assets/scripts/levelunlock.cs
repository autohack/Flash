using UnityEngine;
using System.Collections;
/// <summary>
/// Level unlock.
/// </summary>
public class levelunlock : MonoBehaviour {
	public GameObject locklevel2;
	public GameObject locklevel3;
	public int score;
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		score = PlayerPrefs.GetInt ("High Score");
		if (score >= 20) {
			locklevel2.SetActive(false);  //open map
			}
		if (score >= 100) {
			locklevel3.SetActive(false);
		}
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	
	}
}
