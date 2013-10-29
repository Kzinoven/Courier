using UnityEngine;

public class Runner : MonoBehaviour {
//Defines the player/runner class and its properties.
    public static float distanceTraveled;
    public float acceleration;
    public float maxVelocity;
    private bool touchingPlatform;
    public Vector3 jumpVelocity;
	
	private TimeDilation timeDilation;
	
	void Start()
	{
		timeDilation = (TimeDilation)gameObject.GetComponent(typeof(TimeDilation));
	}
	
	// Update is called once per frame
	void Update () {
        //Handle basic jumping.  Will add action and input manager functions in future versions.
        if (touchingPlatform && Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
            touchingPlatform = false;
        }

        // used by Managers
        distanceTraveled = transform.localPosition.x;

        if (Input.GetButton("Fire1"))
            timeDilation.dilate(0.2f, 1.0f);
	}

    // FixedUpdate is called every time physics are calculated, usually multiple times per frame
    void FixedUpdate ()
    {
        // Get up to speed
        if (touchingPlatform)
        {
            rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
        }
        
        // Limit max speed here:
        if (rigidbody.velocity.x > maxVelocity)
        {
            rigidbody.velocity = new Vector3(maxVelocity, rigidbody.velocity.y, rigidbody.velocity.x);
            // Currently overrides jump button controls but succeeds in limiting speed.  Just setting rigidbody.velocity.x is not allowed
        }
        //Reverse max speed limit (unused but still good to have)
        else if (rigidbody.velocity.x < -maxVelocity)
        {
            rigidbody.velocity = new Vector3(-maxVelocity, rigidbody.velocity.y, rigidbody.velocity.x);
        }
        
    }

    //What happens when you hit something?
    void OnCollisionEnter()
    {
        touchingPlatform = true;
    }

    //What happens when you stop touching something?
    void OnCollisionExit ()
    {
        touchingPlatform = false;
    }
}
