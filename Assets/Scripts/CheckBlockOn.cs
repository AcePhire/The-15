using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBlockOn : MonoBehaviour {

    public bool blockOn;

    public string nameOfBlock;

    public bool correctBlock;

    public GameObject oneUp;
    public GameObject oneRight;
    public GameObject oneLeft;
    public GameObject oneDown;

    public bool canGoUp;
    public bool canGoRight;
    public bool canGoLeft;
    public bool canGoDown;

    public GameObject gameManger;

    public int currentPosition;

    private int currentBlock = 0;

    private GameObject nameOfBlockOn;

    private Vector3 positionOfTheBlockOn;

    // Use this for initialization
    void Start () {

        positionOfTheBlockOn = new Vector3(transform.position.x, transform.position.y, 0f);

    }
	
	// Update is called once per frame
	void Update () {

        if (currentBlock <= 14)
        {

            if (gameManger.GetComponent<GameManger>().allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == currentPosition)
            {
                blockOn = true;

                if (gameManger.GetComponent<GameManger>().allBlocks[currentBlock].GetComponent<Block_Movement>().currentTimeBetweenMoving <= 0)
                {
                    nameOfBlockOn.transform.position = positionOfTheBlockOn;
                }
            }

            currentBlock++;

        }
        else
        {
            currentBlock = 0;
        }

    }

    void OnTriggerEnter2D(Collider2D Block)
    {
        if(Block.gameObject.tag == "Block")
        {
            blockOn = true;

            nameOfBlockOn = Block.gameObject;

            Block.gameObject.GetComponent<Block_Movement>().currentPosition = currentPosition;
        }

        if(Block.gameObject.name == nameOfBlock)
        {
            correctBlock = true;
        }
    }

    void OnTriggerExit2D(Collider2D Block)
    {

        blockOn = false;

        correctBlock = false;
        
    }

}

