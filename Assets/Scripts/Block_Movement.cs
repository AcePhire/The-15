using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Movement : MonoBehaviour {

    public bool canGoUp;
    public bool canGoRight;
    public bool canGoLeft;
    public bool canGoDown;

    public int currentPosition;

    public bool moving;

    public GameObject gameManger;

    public float timeBetweenMoving;
    public float currentTimeBetweenMoving;

    public bool buttonClicked;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        moving = false;

        currentTimeBetweenMoving -= Time.deltaTime;
        if (currentTimeBetweenMoving <= 0)
        {
            if ((Input.GetKeyDown(KeyCode.W) && !(Input.GetKeyDown(KeyCode.A)) && !(Input.GetKeyDown(KeyCode.S)) && !(Input.GetKeyDown(KeyCode.D)) && canGoUp == true) || (buttonClicked == true && canGoUp == true))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1f, 0f);
                canGoUp = false;
                canGoRight = false;
                canGoLeft = false;
                canGoDown = false;
                moving = true;
            }

            if ((Input.GetKeyDown(KeyCode.D) && !(Input.GetKeyDown(KeyCode.W)) && !(Input.GetKeyDown(KeyCode.A)) && !(Input.GetKeyDown(KeyCode.S)) && canGoRight == true) || (buttonClicked == true && canGoRight == true))
            {
                transform.position = new Vector3(transform.position.x + 1f, transform.position.y, 0f);
                canGoUp = false;
                canGoRight = false;
                canGoLeft = false;
                canGoDown = false;
                moving = true;
            }

            if ((Input.GetKeyDown(KeyCode.A) && !(Input.GetKeyDown(KeyCode.W)) && !(Input.GetKeyDown(KeyCode.S)) && !(Input.GetKeyDown(KeyCode.D)) && canGoLeft == true) || (buttonClicked == true && canGoLeft == true))
            {
                transform.position = new Vector3(transform.position.x - 1f, transform.position.y, 0f);
                canGoUp = false;
                canGoRight = false;
                canGoLeft = false;
                canGoDown = false;               
                moving = true;
            }

            if ((Input.GetKeyDown(KeyCode.S) && !(Input.GetKeyDown(KeyCode.W)) && !(Input.GetKeyDown(KeyCode.A)) && !(Input.GetKeyDown(KeyCode.D)) && canGoDown == true) || (buttonClicked == true && canGoDown == true))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1f, 0f);
                canGoUp = false;
                canGoRight = false;
                canGoLeft = false;
                canGoDown = false;
                moving = true;
            }

            buttonClicked = false;
        }
    }

    void OnMouseDown()
    {
        buttonClicked = true;
    }

    void OnMouseUp()
    {
        buttonClicked = false;
    }

}
