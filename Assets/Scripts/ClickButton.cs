using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour {

    public bool clicked;

	// Use this for initialization
	void Start () {
        transform.GetChild(0).gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUp()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        clicked = false;
    }

    void OnMouseDown()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        clicked = true;
    }

}
