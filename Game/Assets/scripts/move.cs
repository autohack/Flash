using UnityEngine;
using System.Collections;
/// <summary>
/// Move.
/// </summary>
public class move : MonoBehaviour {
	
	public float car_speed;   //car_speed
	public float max_position = 2.2f;   // track position 
	Vector3 position;
	public UImanager ui;// for destroying  the car


	public Audiomanager am; // audiomanager script 
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		am.carsound.Play ();    // car sound from audiomanger.cs
		position = transform.position;
	}
	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * car_speed * Time.deltaTime;  // for lane changing _ left and right shift 
		position.y += Input.GetAxis ("Vertical") * car_speed * Time.deltaTime;

		position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);   // max left and right position for car
		transform.position = position;
		if (Input.GetButtonDown ("Fire1")) // fire1 = "ctrl"
			RotateLeft();
		if (Input.GetButtonDown ("Fire2")) // fire2 = "alt"
			Rotateright();


	} 
	// for rotating 
	/// <summary>
	/// Rotates the left.
	/// </summary>
	void RotateLeft () {
		transform.Rotate (Vector3.forward * -50*(car_speed*Time.deltaTime)); 
	}
	/// <summary>
	/// Rotateright this instance.
	/// </summary>
	void Rotateright(){
		transform.Rotate (Vector3.forward * 50*(car_speed*Time.deltaTime));
	}
	// Game over on Collision 
	/// <summary>
	/// Raises the collision enter2 d event.
	/// </summary>
	/// <param name="col">Col.</param>
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject); // remove car 
			ui.gameoverActivated(); // change the value 
			am.carsound.Stop(); // for stopping carsound 
		}

	}



}










