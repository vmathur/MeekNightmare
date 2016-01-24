using UnityEngine;
using System.Collections;

public class DynamicVolume : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {

	}
	public GameObject go = GameObject.Find("Sphere");
	// Update is called once per frame
	public float maxDistance = 30.0f;
	void Update () {
        if (Vector3.Distance(GameObject.Find("Sphere").transform.position, player.gameObject.transform.position) >= 30)
        {
            go.GetComponent<AudioSource>().volume = 0.3f;
        }
        else
        {
            float volumeSet = (float)(maxDistance - Vector3.Distance(GameObject.Find("Sphere").transform.position, player.gameObject.transform.position)) / maxDistance;
            go.GetComponent<AudioSource>().volume = volumeSet;
        }
		
	}
}