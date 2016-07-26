using UnityEngine;
using System.Collections;
/// <summary>
/// Scene change.
/// </summary>
public class SceneChange : MonoBehaviour {

	/// <summary>
	/// Changes to scene.
	/// </summary>
	/// <param name="sceneToChangeTo">Scene to change to.</param>
	public void ChangeToScene (int sceneToChangeTo) {

		Application.LoadLevel (sceneToChangeTo);  // number of scene to be changed into
	
	}
}
