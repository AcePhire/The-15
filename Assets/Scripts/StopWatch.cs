using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StopWatch : MonoBehaviour {

    private Text text;

    private float theTime;
    private string seconds;
    private string minutes;

    public bool firstClickOrPress;
    public bool reloaded;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

        seconds = (0).ToString("00");
        minutes = (0).ToString("00");

    }
	
	// Update is called once per frame
	void Update () {

        //rest time
        if (reloaded == true)
        {
            theTime = 0;
            firstClickOrPress = false;
            reloaded = false;
        }

        //start time
        if (firstClickOrPress == true)
        {
            theTime += Time.deltaTime;            
        }

        seconds = Mathf.Floor(theTime % 60).ToString("00");
        minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");

        text.text = minutes + ":" + seconds;

    }
}
