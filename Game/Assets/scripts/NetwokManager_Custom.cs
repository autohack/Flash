using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;
/// <summary>
/// Netwok manager_ custom server.
/// </summary>
public class NetwokManager_Custom : MonoBehaviour {
	/// <summary>
	/// Startups the host.
	/// </summary>
	public void StartupHost()
	{
		SetPort ();
		NetworkManager.singleton.StopHost ();
	}
	/// <summary>
	/// Joins the game.
	/// </summary>
	public void JoinGame()
	{
		SetIPAddress ();
		SetPort ();
		NetworkManager.singleton.StartClient ();

	}
	/// <summary>
	/// Sets the IP address.
	/// </summary>
	void SetIPAddress()
	{
		string ipaddress = GameObject.Find ("InputFieldAddress").transform.FindChild ("Text").GetComponent<Text> ().text;
		NetworkManager.singleton.networkAddress = ipaddress;
	}

	/// <summary>
	/// Sets the port.
	/// </summary>
	void SetPort()
	{
		NetworkManager.singleton.networkPort = 7777;
	}
	/*void  OnlevelWasLoaded(){
	if (level == 0) {
			SetupMenuSceneButtons ();
		}
		/*else 
		{
			SetupOtherSeceneButtons();
		}
	}
	void SetupMenuSceneButtons ()
	{
		GameObject.Find ("Buttonhostserver").GetComponent<Button> ().onClick.RemoveAllListeners ();
		GameObject.Find ("Buttonhostserver").GetComponent<Button> ().onClick.AddListener (StartupHost);

		GameObject.Find ("Buttonjoinserver").GetComponent<Button> ().onClick.RemoveAllListeners ();
		GameObject.Find ("Buttonjoinserver").GetComponent<Button> ().onClick.AddListener (JoinGame);

	}*/


	/*void SetupOtherSeceneButtons()
	{
		GameObject.Find ("Buttonhostserver").GetComponent<Button> ().onClick.RemoveAllListeners ();
	}*/

}
