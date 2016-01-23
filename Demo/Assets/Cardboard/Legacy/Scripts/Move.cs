using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	private CardboardHead head;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		head = Camera.main.GetComponent<StereoController>().Head;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += speed * head.Gaze.direction;

	}
}
