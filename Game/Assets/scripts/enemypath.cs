using UnityEngine;
using System.Collections;

public class enemypath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveTo (gameObject, iTween.Hash ("path", iTweenPath.GetPath ("enemy"), "time", 80 ,"orienttopath" , true));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
