using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Cardboard.SDK.Triggered) {
			TextMesh textObject = GameObject.Find("OverText").GetComponent<TextMesh>();
			textObject.text = "Loading...";
			Application.LoadLevel (1);
		}
	}
}
