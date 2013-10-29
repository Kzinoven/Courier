using UnityEngine;
using System.Collections;

public class TimeDilation : MonoBehaviour
{
	//The rate at which the time changes
	public float warpSpeed;
	
	private float targetScale = 0.2f;
	private float duration;
	
	private enum TimeState
	{
		Slowing,
		Speeding,
		Normal,
		Slowed,
	}
	private TimeState timeState = TimeState.Normal;
	
	//dilate: begin the slowdown process
	public void dilate(float targetScale, float duration)
	{
		this.targetScale = targetScale;
		this.duration = duration;
		timeState = TimeState.Slowing;
	}
	
	private IEnumerator SlowdownTime()
	{
		yield return new WaitForSeconds(duration);
	}
	
	void Update()
	{
		switch(timeState)
		{
			case TimeState.Normal:
				Time.timeScale = 1.0f;
				break;
			case TimeState.Slowed:
				StartCoroutine(SlowdownTime());
				timeState = TimeState.Speeding;
				break;
			case TimeState.Slowing:
				while(Time.timeScale - targetScale > 0.001f)
					Time.timeScale = Mathf.Lerp(Time.timeScale, targetScale, warpSpeed);
				timeState = TimeState.Slowed;
				break;
			case TimeState.Speeding:
				while(1.0f - Time.timeScale > 0.001f)
					Time.timeScale = Mathf.Lerp(Time.timeScale, 1.0f, warpSpeed);
				timeState = TimeState.Normal;
				break;
			default:
				break;
		}
		print (Time.timeScale);
		//smooth out the framerate during the slowdown
		Time.fixedDeltaTime = Time.timeScale * 0.02f;
	}
}