using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Cardboard.SDK.Triggered) {
			TextMesh textObject = GameObject.Find("StartText").GetComponent<TextMesh>();
			textObject.text = "Loading...";
			Application.LoadLevel (1);
		}
	}
}
