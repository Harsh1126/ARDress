using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will move the GameObject based on finger gestures
public class SimpleMove1 : MonoBehaviour
{
	/*public GameObject player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Vector2 touchPosition = Input.GetTouch(0).position;
			double halfScreen = Screen.width / 2.0;

			//Check if it is left or right?
			if(touchPosition.x < halfScreen){
				player.transform.Translate(Vector3.left * 5 * Time.deltaTime);
			} else if (touchPosition.x > halfScreen) {
				player.transform.Translate(Vector3.right * 5 * Time.deltaTime);
			}

		}

	}
	/*void Update() {

		for (var i = 0; i < Input.touchCount; i++) {


			if (Input.GetTouch (i).phase == TouchPhase.Began && i == 0) {
				transform.position = new Vector3 (Input.GetTouch (i).position.x, Input.GetTouch (i).position.y, transform.position.z);
			}
		}
	}

	/*protected virtual void LateUpdate()
	{
		// This will move the current transform based on a finger drag gesture
		Lean.LeanTouch.MoveObject(transform, Lean.LeanTouch.DragDelta);
	}*/

	/*public float speed = 0.000001f;
	void Update(){
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPosition = Input.GetTouch (0).position;
			transform.Translate (touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
		}
	}*/
	/*void Update(){
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			//get the touch position from the screen touch to worldposition
			Vector2 touchedpos = Camera.main.ScreenToWorldPoint (new Vector2 (Input.GetTouch(0).position.x, Input.GetTouch(0).position.y));

			//lerp and set the position of the current object to that of the touch, but smoothly over time
			transform.position = Vector2.Lerp (transform.position, touchedpos, Time.deltaTime * 5);
		}
	}*/
	void Update () {
		for (var i = 0; i < Input.touchCount; i++) {
			// The screen has been touched so store the touch
			if (Input.GetTouch(i).phase == TouchPhase.Stationary || Input.GetTouch(i).phase == TouchPhase.Moved && i == 0) {
				// If the finger is on the screen, move the object smoothly to the touch position
				Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, 10));                
				transform.position = Vector3.Lerp(transform.position, touchPosition, Time.deltaTime);
			}
		}
	}
}