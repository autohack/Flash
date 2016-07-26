using UnityEngine;
using System.Collections;
/// <summary>
/// Car change via menu.
/// </summary>
public class CarChange : MonoBehaviour {
	public Sprite car;


	// Use this for initialization
	/// <summary>
	/// Raises the click event for car change.
	/// </summary>
	void OnClick () {
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		renderer.sprite = car;
	}

	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
	
	}
}
