using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour {

    public static readonly int states = 4;
    public static int state = 0;
    public Button button;
    public Sprite[] img;


    // Use this for initialization
	void Start () {

        button = GetComponent<Button>();
        button.image.sprite = img[state];
    
     }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TileSwitched()
    {
        state = (state + 1) % states;
        button.image.sprite = img[state];
    }
}
