using UnityEngine;
using System.Collections;

public class FindYou : MonoBehaviour {
	float speed  = 1.0f; // move speed
	public GameObject target;

	void Start () {
	}

	void Update () {
		print (transform.position);
		print (target.gameObject.transform.position);
		transform.position = Vector3.MoveTowards(transform.position, target.gameObject.transform.position,   speed*Time.deltaTime);
	}
}
