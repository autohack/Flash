using UnityEngine;
using Pathfinding;
using System.Collections;

[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent (typeof(Seeker))]
public class EnemyAI : MonoBehaviour
{

	// What to chase?
	public Transform target;

	// How many times each second we will update our path
	public float updateRate = 60f;

	private Seeker seeker;
	private Rigidbody2D rb;

	//The calculated path

	public Path path;

	//The AI's speed per second
	public float speed = 300f;
	//Option for how to apply a force using Rigigbody2D.AddForce
	public ForceMode2D fmode;

	[HideInInspector]
	public bool pathisEnded = false;

	// The max distance from the AI to a waypoint for it to continue to the next waypoint
	public float nextWayPointDistance = 100;

	//The way point we are currently moving towards
	private int currentWayPoint = 0;

	public float rotation_constant = 1f;

	private float angle;

	private Vector3 turndir;

	void Start ()
	{
		seeker = GetComponent<Seeker> ();
		//Returns the component of Type Seeker if the game object has one attached, null if it doesn't

		rb = GetComponent<Rigidbody2D> ();

		if (target == null) {
			Debug.LogError ("No Player found.");
			return;
		}

		//Start a new path to the target position, return the result to the OnPathComplete method
		seeker.StartPath (transform.position, target.position, OnPathComplete);
		print ("a");
		StartCoroutine (UpdatePath ());
	}

	IEnumerator UpdatePath ()
	{
		if (target == null) {
			//TODO: Insert a player search here.
			return false;
		}

		seeker.StartPath (transform.position, target.position, OnPathComplete);
		yield return new WaitForFixedUpdate ();
		yield return new WaitForSeconds (1f / updateRate);
		StartCoroutine (UpdatePath ());
	}

	void OnPathComplete (Path p)
	{
		Debug.Log ("We got a path. Did it have an error? " + p.error);
		if (!p.error) {
			path = p;
			currentWayPoint = 0;
		}
	}

	public static float AngleAroundAxis (Vector3 dirA, Vector3 dirB, Vector3 axis)
	{
		// Project A and B onto the plane orthogonal target axis
		dirA = dirA - Vector3.Project (dirA, axis);
		dirB = dirB - Vector3.Project (dirB, axis);

		// Find (positive) angle between A and B
		float angle = Vector3.Angle (dirA, dirB);

		// Return angle multiplied with 1 or -1
		return angle * (Vector3.Dot (axis, Vector3.Cross (dirA, dirB)) < 0 ? -1 : 1);
	}

	void FixedUpdate ()
	{
		if (target == null) {
			//TODO: Insert a player search here.
			return;
		}

		//TODO: Always look at player?

		if (path == null)
			return;

		if (currentWayPoint >= path.vectorPath.Count) {
			if (pathisEnded)
				return;

			Debug.Log ("End of path reached.");
			pathisEnded = true;
			return;
		}

		pathisEnded = false;

		//Direction to the next WayPoint
		Vector3 dir = (path.vectorPath [currentWayPoint] - transform.position).normalized;
		turndir = dir;
		dir *= speed * Time.fixedDeltaTime;
		Vector3 nextDir = (path.vectorPath [currentWayPoint + 3] - transform.position).normalized;
		nextDir *= speed * Time.fixedDeltaTime;

		//Rotate the sprite
		transform.up = rb.velocity;
//		angle = Vector3.Angle (transform.up, rb.velocity);
//		if (angle > 5f) {
//			transform.up = Quaternion.Euler (0f, 0f, 5f) * transform.up;
//		} else if (angle < -5f) {
//			transform.up = Quaternion.Euler (0f, 0f, -5f) * transform.up;
//		}

		//Move the AI
		//rb.AddForce (dir, fmode);
		if (Vector3.Dot (rb.velocity, dir) > -0.1)
			rb.velocity = dir;
		else {
			rb.velocity = nextDir;
			Debug.Log ("transform.up = " + transform.up + "dir = " + dir);
		}
		
	
		float dist = Vector3.Distance (transform.position, path.vectorPath [currentWayPoint]);
		if (dist < ( nextWayPointDistance)) {
			currentWayPoint++;
			return;
		} 


		/*Vector2 moveDirection = rb.velocity;*/
		/*if (moveDirection != Vector2.zero) {
			float angle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle - 90f, Vector3.forward);
			//transform.rotation = Quaternion.Euler (0, 0, angle);

		}*/
		//Debug.Log ("MoveDirection = " + moveDirection + " \ttransform.Rotation = " + transform.rotation);
		//transform.LookAt (velocity, Vector3.up);
	}

	/*void Update ()
	{
		if (turndir == Vector3.zero) {
			rb.angularVelocity = 0f;
		} else {
			float rotationAngle = AngleAroundAxis (transform.up, turndir, Vector3.forward);
			rb.angularVelocity = (rotationAngle * rotation_constant);
			Debug.Log ("rotationAngle = " + rotationAngle + "transform.up = " + transform.up + "turndir = " + turndir);
		}
	}*/
}
