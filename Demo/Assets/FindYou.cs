using UnityEngine;
using System.Collections;

public class FindYou : MonoBehaviour {
	float speed  = 5.0f; // move speed
	public GameObject target;

	void Start () {
	}

	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.gameObject.transform.position,   speed*Time.deltaTime);
	}
}
