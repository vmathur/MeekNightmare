using UnityEngine;
using System.Collections;

public class DynamicVolume : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {

	}
	public GameObject go = GameObject.Find("Sphere");
	// Update is called once per frame
	public float maxDistance = 20.0f;
	void Update () {
		float volumeSet = (float)(maxDistance-Vector3.Distance(GameObject.Find("Sphere").transform.position,player.gameObject.transform.position))/maxDistance;
		go.GetComponent<AudioSource>().volume = volumeSet;
	}
}