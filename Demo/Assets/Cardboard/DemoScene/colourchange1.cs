using UnityEngine;
using System.Collections;

public class colourchange1 : MonoBehaviour
{

    float timer = 0.0f;
    public int index;
    Color[] cColors = new Color[5];

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Color color0 = new Color(0.129f, 0.553f, 0.502f, 1.000f);
        Color color3 = new Color(0.298f, 0.698f, 0.647f, 1.000f);
        Color color1 = new Color(0.867f, 0.435f, 0.588f, 1.000f);
        Color color2 = new Color(0.671f, 0.431f, 0.714f, 1.000f);
        Color color4 = new Color(0.353f, 0.173f, 0.455f, 1.000f);

        Color[] cColors = new Color[5] { color0, color1, color2, color3, color4 };

        timer += Time.deltaTime;
        if (timer > 4)
        {
            print("entering" + " " + index);
            if (++index == cColors.Length) index = 0;

            gameObject.GetComponent<Renderer>().material.color = cColors[index];

            timer = 0.0f;

        }

    }

}
