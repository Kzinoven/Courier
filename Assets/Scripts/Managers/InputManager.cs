using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour
{
	public static List<string> ActionArray;
	
	// Use this for initialization
	void Start ()
	{
		ActionArray = new List<string>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		ArrayList ActionArray = new ArrayList();
		if (Input.GetButtonDown ("Jump"))
		{
			print ("Jumping");
			//sets objects color to red
			gameObject.renderer.material.color = Color.red;
			//adds Jump to the array
			ActionArray.Add("Jump");
		}
		if (Input.GetButtonDown ("Punch"))
		{
			print ("Punching");
			//sets objects color to green
			gameObject.renderer.material.color = Color.green;
			//adds Punch to the array
			ActionArray.Add("Punch");
		}
		if (Input.GetButtonDown ("Slide"))
		{
			print ("Sliding");
			//sets objects color to blue
			gameObject.renderer.material.color = Color.blue;
			//adds Slide to the array
			ActionArray.Add ("Slide");
			
		}
		if (Input.GetButtonDown ("Roll"))
		{
			print ("Rolling");
			//sets objects color to white
			gameObject.renderer.material.color = Color.white;
			//adds Roll to the array
			ActionArray.Add("Roll");
		}
		if (Input.GetButtonDown ("Grab"))
		{
			print ("Grabbing");
			//sets objects color to black
			gameObject.renderer.material.color = Color.black;
			//adds Grab to the array
			ActionArray.Add("Grab");
		}
		if (Input.GetButtonDown ("Dodge"))
		{
			print ("Dodging");
			//sets objects color to yellow
			gameObject.renderer.material.color = Color.yellow;
			//adds Dodge to the array
			ActionArray.Add("Dodge");
		}
	}
}

