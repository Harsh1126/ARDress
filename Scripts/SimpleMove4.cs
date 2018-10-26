using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove4 : MonoBehaviour {

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
				transform.position = Vector3.Lerp(transform.position, touchPosition, Time.deltaTime * 5f);
			}
		}
	}
}
