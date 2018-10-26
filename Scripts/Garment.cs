using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Garment: MonoBehaviour {
	public Image img;
	public GameObject buttonPrefab;
	public Transform buttonContainer;

	private void Start(){
		Sprite[] sprites = Resources.LoadAll<Sprite> ("Garment");
		foreach (Sprite s in sprites) {
			GameObject go = Instantiate (buttonPrefab) as GameObject;
			go.transform.SetParent (buttonContainer, false);
			go.GetComponent<Image> ().sprite = s;

			string sName = s.name;
			go.GetComponent<Button> ().onClick.AddListener (() => OnButtonClick (sName));
		}
	}

	public void OnButtonClick(string imgName){
		img.sprite = Resources.Load<Sprite> ("Garment/" + imgName);
	}


}
