using UnityEngine;
using System.Collections;

public class FindYou : MonoBehaviour {
	float speed  = 1.0f; // move speed
	public GameObject target;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position,   speed*Time.deltaTime);
	}
}
