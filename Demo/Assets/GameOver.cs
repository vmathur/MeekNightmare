using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public GameObject target;
	private Vector3 startingPosition;

	void OnTriggerEnter(Collider enter){
		Debug.Log("hi");
		target.transform.localPosition = startingPosition;

		Debug.Log("sup");
	}
}
