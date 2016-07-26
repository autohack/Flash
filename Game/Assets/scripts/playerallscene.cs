using UnityEngine;
using System.Collections;
/// <summary>
/// Playerallscene.
/// </summary>
public class playerallscene : MonoBehaviour {

	// Use this for initialization
	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
	
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	
	}
}
