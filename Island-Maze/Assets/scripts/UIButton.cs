using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour {

    public static readonly int states = 3;
    public static int state = 0;

    Image img;
    Color[] tileCols = new Color[] { Color.blue, Color.red, Color.green };


    // Use this for initialization
	void Start () {
        img = GetComponent<Image>();
        img.color = tileCols[state];
            
     }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TileSwitched()
    {
        state = (state + 1) % states;
        img.color = tileCols[state];
    }
}
