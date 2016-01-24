using UnityEngine;
using System.Collections;

public class FollowAttach : MonoBehaviour {
	NavMeshAgent agent;
	public Transform target;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
	}

	void OnCollisionEnter(Collision collision) {
		print (collision.gameObject.name);
	}
}
