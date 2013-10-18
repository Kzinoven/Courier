using UnityEngine;

public class Runner : MonoBehaviour {

    public static float distanceTraveled;
    public float acceleration;
    public float maxVelocity;
    private bool touchingPlatform;
    public Vector3 jumpVelocity;
	
	// Update is called once per frame
	void Update () {
        if (touchingPlatform && Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
            touchingPlatform = false;
        }
        // used by Managers
        distanceTraveled = transform.localPosition.x;

        // since movement is calculated by fixedUpdate, this doesn't work.  Will refactor in the future.
        if (Input.GetButtonDown("Fire1"))
            Time.timeScale = 0.2f;
        else Time.timeScale = 1.0f;
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
