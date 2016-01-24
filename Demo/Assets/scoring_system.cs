using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[RequireComponent(typeof(Text))]
public class scoring_system : MonoBehaviour {
    private Text text;
    private float value = 0;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        value = Mathf.Round(Time.unscaledTime);
        text.text = "Score: " + value;
	}
}
