using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {
	public GameObject cam1;
	public GameObject cam2;

	public void CamMain(){
		cam1.SetActive (true);
		cam2.SetActive (false);
	}
	public void CamOne ()
	{
		cam1.SetActive (false);
		cam2.SetActive (true);
	}
}
