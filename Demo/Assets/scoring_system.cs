using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(Text))]
public class scoring_system : MonoBehaviour {
    private Text text;
    public static float value = 0;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();

//		value += Mathf.Round(Time.unscaledTime);
	}
	
	// Update is called once per frame
	void Update () {
		value += (Mathf.Round(Time.unscaledTime))/100;
        text.text = "Dreaming for " + value;
	}

	public void death () {
		print ("thevalueiszero");
		value = 0;
	}
}
