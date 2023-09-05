using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsController : MonoBehaviour {

    public Animator anim;

    public bool overhome;
    public bool overlibrary;
    public bool overleaderboard;
    public bool oversettings;

    // Use this for initialization
    void Start () {
        anim.SetBool("OverHome", true);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {

        if (gameObject.name == "Home")
        {
            overhome = true;
        }

        if (gameObject.name == "Library")
        {
            overlibrary = true;
        }

        if (gameObject.name == "Leaderboard")
        {
            overleaderboard = true;
        }

        if (gameObject.name == "Settings")
        {
            oversettings = true;
        }

        anim.SetBool("OverHome", overhome);

        anim.SetBool("OverLibrary", overlibrary);

        anim.SetBool("OverLeaderboard", overleaderboard);

        anim.SetBool("OverSettings", oversettings);

    }

    void OnMouseUp()
    {
        if (gameObject.name == "Home")
        {
            overlibrary = false;
            overleaderboard = false;
            oversettings = false;
        }

        if (gameObject.name == "Library")
        {
            overhome = false;
            overleaderboard = false;
            oversettings = false;
        }

        if (gameObject.name == "Leaderboard")
        {
            overhome = false;
            overlibrary = false;
            oversettings = false;
        }

        if (gameObject.name == "Settings")
        {
            overhome = false;
            overlibrary = false;
            overleaderboard = false;
        }
    }

}
