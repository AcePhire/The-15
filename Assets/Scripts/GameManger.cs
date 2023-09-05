using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour {

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject twelve;
    public GameObject thirteen;
    public GameObject fourteen;
    public GameObject fifteen;
    public GameObject sixteen;

    public GameObject oneB;
    public GameObject twoB;
    public GameObject threeB;
    public GameObject fourB;
    public GameObject fiveB;
    public GameObject sixB;
    public GameObject sevenB;
    public GameObject eightB;
    public GameObject nineB;
    public GameObject tenB;
    public GameObject elevenB;
    public GameObject twelveB;
    public GameObject thirteenB;
    public GameObject fourteenB;
    public GameObject fifteenB;

    public bool Bloks;

    public GameObject[] allBlocks;

    public int currentBlock = 0;

    private Vector3 first;
    private Vector3 second;
    private Vector3 third;
    private Vector3 forth;
    private Vector3 fifth;
    private Vector3 sixth;
    private Vector3 seventh;
    private Vector3 eighth;
    private Vector3 ninth;
    private Vector3 tenth;
    private Vector3 eleventh;
    private Vector3 twelvth;
    private Vector3 thirteenth;
    private Vector3 fourteenth;
    private Vector3 fifteenth;
    private Vector3 sixteenth;

    List<Vector3> randomizer;

    public int allOnBlocks;

    public GameObject[] allColliders;

    public GameObject backButton;
    public GameObject relaodButton;
    public GameObject stopWatch;

    // Use this for initialization
    void Start () {

        allBlocks = new GameObject[] { oneB, twoB, threeB, fourB, fiveB, sixB, sevenB, eightB, nineB, tenB, elevenB, twelveB, thirteenB, fourteenB, fifteenB };
        allColliders = new GameObject[] { one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, sixteen };

        randomizer = new List<Vector3>(new Vector3[] { one.transform.position, two.transform.position, three.transform.position, four.transform.position, five.transform.position, six.transform.position, seven.transform.position, eight.transform.position, nine.transform.position, ten.transform.position, eleven.transform.position, twelve.transform.position, thirteen.transform.position, fourteen.transform.position, fifteen.transform.position, sixteen.transform.position });

        //Setting Random Number
        RandomizeBlocks();

    }
	
	// Update is called once per frame
	void Update(){

        allOnBlocks = 0;

        randomizer = new List<Vector3>(new Vector3[] { one.transform.position, two.transform.position, three.transform.position, four.transform.position, five.transform.position, six.transform.position, seven.transform.position, eight.transform.position, nine.transform.position, ten.transform.position, eleven.transform.position, twelve.transform.position, thirteen.transform.position, fourteen.transform.position, fifteen.transform.position, sixteen.transform.position });

        //reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            RandomizeBlocks();
            StaticTimeBetweenMoves();
            stopWatch.GetComponent<StopWatch>().reloaded = true;
        }

        //block surrounding
        if (currentBlock <= 14)
        {   
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 1)
            {
                if (one.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                } 
                if (one.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                } 
                if (one.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                } 
                if (one.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (one.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (one.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 2)
            {
                if (two.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (two.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (two.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (two.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (two.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (two.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (two.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 3)
            {
                if (three.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (three.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (three.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (three.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (three.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (three.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (three.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 4)
            {
                if (four.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (four.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (four.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (four.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (four.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (four.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 5)
            {
                if (five.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (five.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (five.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (five.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (five.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (five.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (five.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 6)
            {
                if (six.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (six.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (six.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (six.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (six.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (six.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (six.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (six.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 7)
            {
                if (seven.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (seven.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (seven.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (seven.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (seven.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (seven.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (seven.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (seven.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 8)
            {
                if (eight.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (eight.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (eight.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (eight.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (eight.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (eight.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (eight.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 9)
            {
                if (nine.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (nine.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (nine.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (nine.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (nine.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (nine.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (nine.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 10)
            {
                if (ten.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (ten.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (ten.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (ten.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (ten.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (ten.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (ten.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (ten.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 11)
            {
                if (eleven.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (eleven.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (eleven.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (eleven.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (eleven.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (eleven.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (eleven.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (eleven.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 12)
            {
                if (twelve.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (twelve.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (twelve.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (twelve.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (twelve.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (twelve.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }

                if (twelve.GetComponent<CheckBlockOn>().oneDown.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 13)
            {
                if (thirteen.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (thirteen.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (thirteen.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (thirteen.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (thirteen.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (thirteen.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 14)
            {
                if (fourteen.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (fourteen.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (fourteen.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (fourteen.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (fourteen.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (fourteen.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (fourteen.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 15)
            {
                if (fifteen.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (fifteen.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (fifteen.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (fifteen.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (fifteen.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (fifteen.GetComponent<CheckBlockOn>().oneRight.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = true;
                }

                if (fifteen.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }
            }
            if (allBlocks[currentBlock].GetComponent<Block_Movement>().currentPosition == 16)
            {
                if (sixteen.GetComponent<CheckBlockOn>().oneUp.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                if (sixteen.GetComponent<CheckBlockOn>().oneRight.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoRight = false;
                }
                if (sixteen.GetComponent<CheckBlockOn>().oneLeft.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                if (sixteen.GetComponent<CheckBlockOn>().oneDown.name == "OutBocCollider")
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoDown = false;
                }

                if (sixteen.GetComponent<CheckBlockOn>().oneUp.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoUp = true;
                }

                if (sixteen.GetComponent<CheckBlockOn>().oneLeft.GetComponent<CheckBlockOn>().blockOn == true)
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = false;
                }
                else
                {
                    allBlocks[currentBlock].GetComponent<Block_Movement>().canGoLeft = true;
                }
            }


            if (allBlocks[0].GetComponent<Block_Movement>().moving == true || allBlocks[1].GetComponent<Block_Movement>().moving == true || allBlocks[2].GetComponent<Block_Movement>().moving == true || allBlocks[3].GetComponent<Block_Movement>().moving == true || allBlocks[4].GetComponent<Block_Movement>().moving == true || allBlocks[5].GetComponent<Block_Movement>().moving == true || allBlocks[6].GetComponent<Block_Movement>().moving == true || allBlocks[7].GetComponent<Block_Movement>().moving == true || allBlocks[8].GetComponent<Block_Movement>().moving == true || allBlocks[9].GetComponent<Block_Movement>().moving == true || allBlocks[10].GetComponent<Block_Movement>().moving == true || allBlocks[11].GetComponent<Block_Movement>().moving == true || allBlocks[12].GetComponent<Block_Movement>().moving == true || allBlocks[13].GetComponent<Block_Movement>().moving == true || allBlocks[14].GetComponent<Block_Movement>().moving == true)
            {
                StaticTimeBetweenMoves();
                stopWatch.GetComponent<StopWatch>().firstClickOrPress = true;
            }

            currentBlock++;


        }
        else
        {
            currentBlock = 0;
        }

        //# of correct blocks
        if (true)
        {
            if (one.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (two.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (three.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (four.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (five.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (six.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (seven.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (eight.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (nine.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (ten.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (eleven.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (twelve.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (thirteen.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (fourteen.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (fifteen.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }

            if (sixteen.GetComponent<CheckBlockOn>().blockOn == true)
            {
                allOnBlocks += 1;
            }
        }

        //back button
        if (backButton.GetComponent<ClickButton>().clicked == true)
        {
            SceneManager.LoadScene("Levels");
        }

        //reload button
        if (relaodButton.GetComponent<ClickButton>().clicked == true)
        {
            RandomizeBlocks();
            StaticTimeBetweenMoves();
            relaodButton.GetComponent<ClickButton>().clicked = false;
            stopWatch.GetComponent<StopWatch>().reloaded = true;
        }

    }
    
    void RandomizeBlocks()
    {
        
        first = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(first);
        second = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(second);
        third = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(third);
        forth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(forth);
        fifth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(fifth);
        sixth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(sixth);
        seventh = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(seventh);
        eighth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(eighth);
        ninth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(ninth);
        tenth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(tenth);
        eleventh = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(eleventh);
        twelvth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(twelvth);
        thirteenth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(thirteenth);
        fourteenth = randomizer[Random.Range(0, randomizer.Count)];
        randomizer.Remove(fourteenth);
        fifteenth = randomizer[Random.Range(0, randomizer.Count)];

        oneB.transform.position = first;
        twoB.transform.position = second;
        threeB.transform.position = third;
        fourB.transform.position = forth;
        fiveB.transform.position = fifth;
        sixB.transform.position = sixth;
        sevenB.transform.position = seventh;
        eightB.transform.position = eighth;
        nineB.transform.position = ninth;
        tenB.transform.position = tenth;
        elevenB.transform.position = eleventh;
        twelveB.transform.position = twelvth;
        thirteenB.transform.position = thirteenth;
        fourteenB.transform.position = fourteenth;
        fifteenB.transform.position = fifteenth;
    }
    void StaticTimeBetweenMoves()
    {
        oneB.GetComponent<Block_Movement>().currentTimeBetweenMoving = oneB.GetComponent<Block_Movement>().timeBetweenMoving;
        twoB.GetComponent<Block_Movement>().currentTimeBetweenMoving = twoB.GetComponent<Block_Movement>().timeBetweenMoving;
        threeB.GetComponent<Block_Movement>().currentTimeBetweenMoving = threeB.GetComponent<Block_Movement>().timeBetweenMoving;
        fourB.GetComponent<Block_Movement>().currentTimeBetweenMoving = fourB.GetComponent<Block_Movement>().timeBetweenMoving;
        fiveB.GetComponent<Block_Movement>().currentTimeBetweenMoving = fiveB.GetComponent<Block_Movement>().timeBetweenMoving;
        sixB.GetComponent<Block_Movement>().currentTimeBetweenMoving = sixB.GetComponent<Block_Movement>().timeBetweenMoving;
        sevenB.GetComponent<Block_Movement>().currentTimeBetweenMoving = sevenB.GetComponent<Block_Movement>().timeBetweenMoving;
        eightB.GetComponent<Block_Movement>().currentTimeBetweenMoving = eightB.GetComponent<Block_Movement>().timeBetweenMoving;
        nineB.GetComponent<Block_Movement>().currentTimeBetweenMoving = nineB.GetComponent<Block_Movement>().timeBetweenMoving;
        tenB.GetComponent<Block_Movement>().currentTimeBetweenMoving = tenB.GetComponent<Block_Movement>().timeBetweenMoving;
        elevenB.GetComponent<Block_Movement>().currentTimeBetweenMoving = elevenB.GetComponent<Block_Movement>().timeBetweenMoving;
        twelveB.GetComponent<Block_Movement>().currentTimeBetweenMoving = twelveB.GetComponent<Block_Movement>().timeBetweenMoving;
        thirteenB.GetComponent<Block_Movement>().currentTimeBetweenMoving = thirteenB.GetComponent<Block_Movement>().timeBetweenMoving;
        fourteenB.GetComponent<Block_Movement>().currentTimeBetweenMoving = fourteenB.GetComponent<Block_Movement>().timeBetweenMoving;
        fifteenB.GetComponent<Block_Movement>().currentTimeBetweenMoving = fifteenB.GetComponent<Block_Movement>().timeBetweenMoving;
    }
}
