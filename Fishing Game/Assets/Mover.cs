using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
		
		private float speed;
		private float xSpeed;
		private float zSpeed;
		
		
		void Start () {
			
			speed = 5f;
			
			
		}
		
		void Update () {
			xSpeed = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			zSpeed = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
			
			transform.Translate (Vector3.forward * xSpeed);
			transform.Translate (Vector3.down * zSpeed);
			
			if (Input.GetKey (KeyCode.UpArrow)) {
				
				transform.Translate (Vector3.left * speed * Time.deltaTime);
				
			}
			
			if (Input.GetKey (KeyCode.DownArrow)) {
				
				transform.Translate (Vector3.right * speed * Time.deltaTime);
				
			}
			
		}
	}