using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(Text))]
public class scoring_system : MonoBehaviour {
    private Text text;
    public static float timer = 0.0f;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();

//		value += Mathf.Round(Time.unscaledTime);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
        text.text = "Dream Seconds: " + timer;
	}

	public void death () {
		print ("thevalueiszero");
		timer = 0;
	}
}
