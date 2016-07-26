using UnityEngine;
using System.Collections;
/// <summary>
/// Car position in First scene.
/// </summary>
public class carposition : MonoBehaviour {
	public GameObject[] cars;
	int carNo;
	public float maxpos = 2.0f; // road limit
	public float delayTimer = 1f; //timedelay for each car
	float  timer;
	// Use this for initialization
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		timer = delayTimer;
	}

	
	// Update is called once per frame
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carpos = new Vector3 (Random.Range (-2.2f, 2.2f), transform.position.y, transform.position.z); // for random position of car
			carNo = Random.Range(0,5);
			Instantiate (cars[carNo], carpos, transform.rotation); // start enemy car
			timer = delayTimer;
		
		}

	}
}
/*public float car_speed;   //car_speed
	public float rotation; //for rotation
	Vector3 position;
	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * car_speed * Time.deltaTime;  // for lane changing _ left and right shift 
		position.y += Input.GetAxis ("Vertical") * car_speed * Time.deltaTime;
		transform.position = position;
		if (Input.GetButtonDown ("Fire1")) // fire1 = "ctrl"
			RotateLeft();
		if (Input.GetButtonDown ("Fire2")) // fire2 = "alt"
			Rotateright();
	}
	// for rotating 
	void RotateLeft () {
		transform.Rotate (Vector3.forward * -(rotation)*(car_speed*Time.deltaTime)); 
	}
	void Rotateright(){
		transform.Rotate (Vector3.forward * (rotation)*(car_speed*Time.deltaTime));
	}*/