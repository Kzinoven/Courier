using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {
/*
	Actor.cs
*/
	#region fields
	private Vector3 actorVelocity;
	public Vector3 termVelocity;
	private Vector3 actorAcceleration;
	protected bool grounded;
	#endregion
	
	#region functions
	// Use this for initialization
	void Start () {
		grounded = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter () {
		//check for tag
		grounded = true;
	}
	
	void OnCollisionExit () {
		//check for tag
		grounded = false;
	}
	#endregion
}
//end Actor