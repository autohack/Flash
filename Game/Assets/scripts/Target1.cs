using UnityEngine;
using System.Collections;

public class Target1 : MonoBehaviour {

	public Transform target;
	public Vector3[] positions = new Vector3[10];
	private int current = 0;
	private float dist;
	public float lookat_distance;
	// Use this for initialization
	void Start ()
	{
		positions [0] = new Vector3 (104f, -292f, 0f);
		positions [1] = new Vector3 (2054.5f, -299f, 0f);
		positions [2] = new Vector3 (2043.7f, -407f, 0f);
		positions [3] = new Vector3 (340.5f, -438f, 0f);
		positions [4] = new Vector3 (358.5f, -1167f, 0f);
		positions [5] = new Vector3 (1280f, -1200f, 0f);
		positions [6] = new Vector3 (1273.7f, -1293f, 0f);
		positions [7] = new Vector3 (98f, -1290f, 0f);
		positions [8] = new Vector3 (86f, -1041f, 0f);
	}

	// Update is called once per frame
	void Update ()
	{
		dist = Vector3.Distance (target.position, transform.position);

		if (dist < lookat_distance) {
			current++;
			transform.position = positions [current];
		}



	}
}
