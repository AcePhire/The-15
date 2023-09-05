using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChooseLevel : MonoBehaviour {

    public Animator anim;

    public string levelToLoad;

	// Use this for initialization
	void Start () {

        transform.GetChild(0).gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseExit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        if (anim.GetBool("OverHome"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            SceneManager.LoadScene(levelToLoad);
        }
        
    }

}
