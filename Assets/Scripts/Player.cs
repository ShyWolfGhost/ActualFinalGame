using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;

public class Player : MonoBehaviour
{
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Space;
    public KeyCode Enter;
    
    

    public SpriteRenderer Sren;

    //public bool EndViz;

    //all the cats

    public Sprite starter;
    //public Sprite Left1;
    //public Sprite Left2;
    //public Sprite Left3;

    //public Sprite Left4;

    //repeteofstarter;
    //public Sprite Left6;

    //starter 
    //repeteofstarter;
    //public Sprite Right2;

    // left 2
    //public Sprite Right4;

    //left 2;
    //public Sprite Right6;
    //public Sprite GoodEndSprite;
    //public Sprite BadEndSprite;

    public Sprite GoodPaws;
    public Sprite BadPaws;
    public Sprite GoodPawsEnd;
    public Sprite BadPawsEnd;
    
    public Sprite GoodJ;
    public Sprite BadJ;
    public Sprite GoodJEnd;
    public Sprite BadJEnd;
    
    public Sprite GoodO;
    public Sprite BadO;
    public Sprite GoodOEnd;
    public Sprite BadOEnd;
    



    // Start is called before the first frame update
    void Awake()
    {
        //if (GameManager.Instance.RouteNum == 1)
       // {
            //GameManager.Instance.QuestNum = 0;
            //ColorNum = 0;
            //GoodAns = 0;
            //BadAns = 0;

       // }
       // else if (GameManager.Instance.RouteNum == 2)
        //{
            //GameManager.Instance.QuestNum = 7;
            //ColorNum = 0;
            //GoodAns = 0;
            //BadAns = 0;

        //}
        //else if (GameManager.Instance.RouteNum == 3)
        //{
            //GameManager.Instance.QuestNum = 14;
            //ColorNum = 0;
            //GoodAns = 0;
            //BadAns = 0;

        //}
    }
    void Start()
    {
        Sren = GetComponent<SpriteRenderer>();
        
        Debug.Log("Sren Success");
        //set all int's to Zero
        // Debug.Log("Route: "+GameManager.Instance.RouteNum );
       
        //else ()
        //{
        // Debug.Log("Fuck you");
        //}

        //QuestNum = 0;
        //ColorNum = 0;
        //GoodAns = 0;
        //BadAns = 0;
        //Plan: Choose good ans: Good increase by 1
        //Choose bad ans: bad increase by 1
        //code perquestion
        //code cat sprite
        //the 2 dif endings
    }

    //3=left 2=right

    // Update is called once per frame
    void Update()
    {
        //Change "GetKey" to "GetKeyDown" because GetKey happens constantly
        //Make an if statement that doesn't let the answer functions run if QuestNum is 7 or more
//PAWSTEN


        //Debug.Log("Quest Num: " + GameManager.Instance.QuestNum.ToString());
        Debug.Log( "ROUTE NUM: " + GameManager.Instance.RouteNum.ToString());
        Debug.Log( "GOo ANS NUM: " + GameManager.Instance.GoodAns.ToString());
        Debug.Log( "Bad NUM: " + GameManager.Instance.BadAns.ToString());
        Debug.Log( "Color: " + GameManager.Instance.ColorNum.ToString());
        
        
        if (GameManager.Instance.RouteNum == 1)
        {

            if (GameManager.Instance.QuestNum <= 6)
            {
                Debug.Log(GameManager.Instance.QuestNum);
                GameManager.Instance.QuestText.text = GameManager.Instance.Questions[GameManager.Instance.QuestNum];
                GameManager.Instance.LeftText.text = GameManager.Instance.LeftAns[GameManager.Instance.QuestNum];
                GameManager.Instance.RightText.text = GameManager.Instance.RightAns[GameManager.Instance.QuestNum];
                GameManager.Instance.QuestText.color = Color.magenta;
                GameManager.Instance.EndingText.color = Color.magenta;
                //GameManager.Instance.QuestText.font=Font.;
                if (GameManager.Instance.QuestNum == 0)
                {
                    Debug.Log("Color Num is:" + GameManager.Instance.ColorNum.ToString());
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodPaws;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadPaws;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }

                }
                else if (GameManager.Instance.QuestNum == 1)
                {

                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodPaws;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadPaws;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 2)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadPaws;

                        Debug.Log("bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodPaws;

                        Debug.Log("good");
                        GoodAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 3)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadPaws;

                        Debug.Log("bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodPaws;
                        Debug.Log("Good");
                        GoodAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 4)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodPaws;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadPaws;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 5)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodPaws;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadPaws;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 6)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                    

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
            }
            else
            {
                GameManager.Instance.mRestart.gameObject.SetActive(true);
               
               if (GameManager.Instance.GoodAns > GameManager.Instance.BadAns)
                {
                    Inviz();
                    GameManager.Instance.EndingText.text = GameManager.Instance.Endings[1];
                    Sren.sprite = GoodPawsEnd;
                    GameManager.Instance.AwsCheck = true;
                    if (Input.GetKeyDown(Space) && GameManager.Instance.AllCheck == false)
                    {
                        
                        ResetGOOD();

                    }
                    else if (Input.GetKeyDown(Space) && GameManager.Instance.AllCheck == true)
                    {
                        
                        SceneManager.LoadScene("TrueEnd");
                        Debug.Log("VICTORY SCREECHHHH");

                    }
                }
                else if (GameManager.Instance.GoodAns <= GameManager.Instance.BadAns)
                {
                    Inviz();
                    GameManager.Instance.EndingText.text = GameManager.Instance.Endings[0];
                    Sren.sprite = BadPawsEnd;
                    if (Input.GetKeyDown(Space))
                    {
                        ResetBAD();
                        

                    }
                }
            }

        }
        //END Of Pawsten
        
        
        
        
        
  //    START OF GEOFF  
else if (GameManager.Instance.RouteNum == 2)
        {

            if (GameManager.Instance.QuestNum <= 13)
            {
                Debug.Log(GameManager.Instance.QuestNum);
                GameManager.Instance.QuestText.text = GameManager.Instance.Questions[GameManager.Instance.QuestNum];
                GameManager.Instance.LeftText.text = GameManager.Instance.LeftAns[GameManager.Instance.QuestNum];
                GameManager.Instance.RightText.text = GameManager.Instance.RightAns[GameManager.Instance.QuestNum];
                GameManager.Instance.QuestText.color = Color.cyan;
                GameManager.Instance.EndingText.color = Color.cyan;
                
                if (GameManager.Instance.QuestNum == 7)
                {
                    Debug.Log("Color Num is:" + GameManager.Instance.ColorNum.ToString());
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                       Sren.sprite = BadJ;

                       
                        Debug.Log("Bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodJ;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                }
                else if (GameManager.Instance.QuestNum == 8)
                {

                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodJ;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadJ;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 9)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadJ;

                        Debug.Log("bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodJ;
                        Debug.Log("good");
                        GoodAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 10)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadJ;
                        
                        Debug.Log("bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodJ;
                        Debug.Log("Good");
                        GoodAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 11)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodJ;
                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadJ;
                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 12)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodJ;
                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadJ;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 13)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodJ;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadJ;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
            }
            else
            {
                GameManager.Instance.mRestart.gameObject.SetActive(true);
                if (GameManager.Instance.GoodAns > GameManager.Instance.BadAns)
                {
                    Inviz();
                    GameManager.Instance.EndingText.text = GameManager.Instance.Endings[3];
                    Sren.sprite = GoodJEnd;               
                    GameManager.Instance.GeoffCheck = true;
                    if (Input.GetKeyDown(Space) && GameManager.Instance.AllCheck == false)
                    {
                        
                        ResetGOOD();

                    }
                    else if (Input.GetKeyDown(Space) && GameManager.Instance.AllCheck == true)
                    {
                        
                        SceneManager.LoadScene("TrueEnd");
                        Debug.Log("VICTORY SCREECHHHH");

                    }
                }
                else if (GameManager.Instance.GoodAns <= GameManager.Instance.BadAns)
                {
                    Sren.sprite = BadJEnd;
                    Inviz();
                    GameManager.Instance.EndingText.text = GameManager.Instance.Endings[2];
                    //Sren.sprite = BadEndSprite;
                    if (Input.GetKeyDown(Space))
                    {
                        ResetBAD();
                        

                    }
                }
            }

        }
        //END Of GEOFF
        
        
        
        
        
        
        
        
        
        
        //Ott
        
        else if (GameManager.Instance.RouteNum == 3)
        {

            if (GameManager.Instance.QuestNum <= 20)
            {
                Debug.Log(GameManager.Instance.QuestNum);
                GameManager.Instance.QuestText.text = GameManager.Instance.Questions[GameManager.Instance.QuestNum];
                GameManager.Instance.LeftText.text = GameManager.Instance.LeftAns[GameManager.Instance.QuestNum];
                GameManager.Instance.RightText.text = GameManager.Instance.RightAns[GameManager.Instance.QuestNum];
                GameManager.Instance.QuestText.color = Color.yellow;
                GameManager.Instance.EndingText.color = Color.yellow;
                
                if (GameManager.Instance.QuestNum == 14)
                {
                    Debug.Log("Color Num is:" + GameManager.Instance.ColorNum.ToString());
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodO;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadO;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }

                }
                else if (GameManager.Instance.QuestNum == 15)
                {

                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodO;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadO;

                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 16)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadO;

                        Debug.Log("bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                       Sren.sprite = GoodO;

                        Debug.Log("good");
                        GoodAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 17)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadO;

                        Debug.Log("bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodO;

                        Debug.Log("Good");
                        GoodAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 18)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = GoodO;

                        Debug.Log("Good");
                        GoodAnsFunc();
                       
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = BadO;
                        
                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                }
                else if (GameManager.Instance.QuestNum == 19)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                       Sren.sprite = BadO;

                        
                        Debug.Log("Bad");
                        BadAnsFunc();
                    }
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodO;
                        Debug.Log("Good");
                        GoodAnsFunc();

                       
                }
                else if (GameManager.Instance.QuestNum == 20)
                {
                    if (Input.GetKeyDown(Left))
                    {
                        GameManager.Instance.LeftText.color = Color.cyan;
                        GameManager.Instance.RightText.color = Color.black;
                        Debug.Log("Left works");
                        GameManager.Instance.ColorNum = 3;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 3)
                    {
                        Sren.sprite = BadO;
                        
                        Debug.Log("Bad");
                        BadAnsFunc();
                    }

                    else if (Input.GetKeyDown(Right))
                    {
                        GameManager.Instance.RightText.color = Color.cyan;
                        GameManager.Instance.LeftText.color = Color.black;
                        Debug.Log("Right Works");
                        GameManager.Instance.ColorNum = 2;

                    }
                    else if (Input.GetKeyDown(Enter) && GameManager.Instance.ColorNum == 2)
                    {
                        Sren.sprite = GoodO;
                        Debug.Log("Good");
                        GoodAnsFunc();
                        
                    }
                }
            }
            else
            {
                GameManager.Instance.mRestart.gameObject.SetActive(true);
                
                if (GameManager.Instance.GoodAns > GameManager.Instance.BadAns)
                {
                    Inviz();
                    GameManager.Instance.EndingText.text = GameManager.Instance.Endings[5];
                    Sren.sprite = GoodOEnd;
                    GameManager.Instance.OttCheck = true;
                    if (Input.GetKeyDown(Space) && GameManager.Instance.AllCheck == false)
                    {
                        
                        ResetGOOD();

                    }
                    else if (Input.GetKeyDown(Space) && GameManager.Instance.AllCheck == true)
                    {
                        
                        SceneManager.LoadScene("TrueEnd");
                        Debug.Log("VICTORY SCREECHHHH");

                    }
                }
                else if (GameManager.Instance.GoodAns <= GameManager.Instance.BadAns)
                {
                    Sren.sprite = BadOEnd;
                    Inviz();
                    GameManager.Instance.EndingText.text = GameManager.Instance.Endings[4];
                    //Sren.sprite = BadEndSprite;
                    if (Input.GetKeyDown(Space))
                    {
                        ResetBAD();
                        

                    }
                }
            }

        }
        //END Of OTT




    }

   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public void GoodAnsFunc()
    {
        GameManager.Instance.GoodAns = GameManager.Instance.GoodAns + 1;
        GameManager.Instance.QuestNum++;
        GameManager.Instance.ColorNum = 0;
        GameManager.Instance.LeftText.color = Color.black;
        GameManager.Instance.RightText.color = Color.black;
        Debug.Log("Good: " + GameManager.Instance.GoodAns.ToString() + ";Bad: " + GameManager.Instance.BadAns.ToString());
    }

    public void BadAnsFunc()
    {
        GameManager.Instance.BadAns = GameManager.Instance.BadAns + 1;
        GameManager.Instance.QuestNum++;
        GameManager.Instance.ColorNum = 0;
        GameManager.Instance.LeftText.color = Color.black;
        GameManager.Instance.RightText.color = Color.black;
        Debug.Log("Good: " + GameManager.Instance.GoodAns.ToString() + ";Bad: " + GameManager.Instance.BadAns.ToString());
    }

    public void Inviz()
    {
        GameManager.Instance.QuestText.text = " ";
        GameManager.Instance.LeftText.text = " ";
        GameManager.Instance.RightText.text = " ";
    }

    public void ResetGOOD()
    {
        //QuestNum = 0;
        //GoodAns = 0;
        //BadAns = 0;
        //ColorNum = 0;
        //Sren.sprite = starter;
        //GameManager.Instance.EndingText.text=" ";
        GameManager.Instance.RouteNum = 0;
        GameManager.Instance.QuestText.text = " ";
        GameManager.Instance.EndingText.text = " ";
        GameManager.Instance.TitleText.text = "So You Want To Join MeowderSlides?";
        GameManager.Instance.InstText.text = "Press 1 for Pawsten\nPress 2 for Jeffie\nPress 3 for Otter";

        //GameManager.Instance.pRen.enabled = true;
        //GameManager.Instance.jRen.enabled = true;
        //GameManager.Instance.oRen.enabled = true;
    }

    public void ResetBAD()
    {
        GameManager.Instance.QuestNum = 0;
        GameManager.Instance.GoodAns = 0;
        GameManager.Instance.BadAns = 0;
        GameManager.Instance.AwsCheck = false;
        GameManager.Instance.OttCheck = false;
        GameManager.Instance.GeoffCheck = false;
        //GameManager.Instance.pRen.enabled = true;
        //GameManager.Instance.jRen.enabled = true;
        //GameManager.Instance.oRen.enabled = true;
        //ColorNum = 0;
        //Sren.sprite = starter;
        //GameManager.Instance.EndingText.text=" ";
        GameManager.Instance.RouteNum = 0;
        GameManager.Instance.QuestText.text = " ";
        GameManager.Instance.EndingText.text = " ";
        GameManager.Instance.TitleText.text = "So You Want To Join MeowderSlides?";
        GameManager.Instance.InstText.text = "Press 1 for Pawsten\nPress 2 for Jeffie\nPress 3 for Otter";

        
    }
}
