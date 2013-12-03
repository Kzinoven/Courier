using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {
/*
	Actor.cs
*/
	#region fields
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