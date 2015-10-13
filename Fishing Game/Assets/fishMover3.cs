using UnityEngine;
using System.Collections;

public class fishMover3 : MonoBehaviour {

	private Transform startPoint, endPoint;
	public float percentage;
	public float speed = 2;
	
	private int direction;
	
	void Start () {
		startPoint = GameObject.Find ("startpoint").transform;
		endPoint = GameObject.Find ("endpoint").transform;
		direction = 1;
	}
	
	void Update () {
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);
		
		speed = Mathf.Max (speed, .000001f);
		percentage += Time.deltaTime/speed * direction;
		
		
		if ((percentage > 1) || (percentage<0)) {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}
	}
}
