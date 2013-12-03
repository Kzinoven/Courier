using UnityEngine;

public class Runner : Actor {
//Defines the player/runner class and its properties.
    public static float distanceTraveled;
    public float acceleration;
    public float maxVelocity;
    public Vector3 jumpVelocity;
	public float gameOverY;
	private Vector3 startPosition;
	
	private TimeDilation timeDilation;
	
	void Start()
	{
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		startPosition = transform.localPosition;
		renderer.enabled = false;
		rigidbody.isKinematic = true;
		enabled = false;
		timeDilation = (TimeDilation)gameObject.GetComponent(typeof(TimeDilation));
	}
	
	// Update is called once per frame
	void Update () {
		
        //Handle basic jumping.  Will add action and input manager functions in future versions.
        if (grounded && Input.GetButtonDown("Jump"))
        {
            rigidbody.AddRelativeForce(jumpVelocity, ForceMode.VelocityChange);
            grounded = false;
        }

        // used by Managers
        distanceTraveled = transform.localPosition.x;
		
		if (transform.localPosition.y < gameOverY)
				GameEventManager.TriggerGameOver();
		
        if (Input.GetButton("Fire1"))
            timeDilation.dilate(0.2f, 1.0f);
	}

    // FixedUpdate is called every time physics are calculated, usually multiple times per frame
    void FixedUpdate ()
    {
        // Get up to speed
        if (grounded)
        {
            rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
        }  
    }
	
	private void GameStart () {
		distanceTraveled = 0f;
		transform.localPosition = startPosition;
		renderer.enabled = true;
		rigidbody.isKinematic = false;
		enabled = true;
	}
	
	private void GameOver () {
		renderer.enabled = false;
		rigidbody.isKinematic = true;
		enabled = false;
	}
}
