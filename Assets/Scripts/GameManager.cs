using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;

    [Header("Questions")] // Organize da inspector  
    [TextArea(2, 100)]
    public List<string> Questions;

    [Header("LeftAns")] // Organize da inspector  
    [TextArea(2, 100)]
    public List<string> LeftAns;

    [Header("RightAns")] // Organize da inspector  
    [TextArea(2, 100)]
    public List<string> RightAns;

    [Header("EndingText")] // Organize da inspector  
    [TextArea(2, 100)]
    public List<string> Endings;


    public Text QuestText;
    public Text LeftText;
    public Text RightText;
    public Text EndingText;
    public Text TitleText;
    public Text InstText;
    public Text mRestartText;

    //in ref to buttons
    public GameObject allButtons;
    public GameObject RouteButtons;


    public Button AwsRoute;
    public Button GeoffRoute;
    public Button OttRoute;
    public Button LeftAnsB;
    public Button RightAnsB;
    public Button mRestart;

    public int RouteNum;
    public int QuestNum;

    public int GoodAns;
    public int BadAns;
    public int ColorNum;

    //bools
    public bool AwsCheck;
    public bool GeoffCheck;
    public bool OttCheck;
    public bool AllCheck;

    public GameObject menuBG;
    public GameObject PAWSBG;
    public GameObject GeoffBG;
    public GameObject OttBG;
    public GameObject ParkBG;

    public GameObject WinBG;

    //make moer backgrounds
    public GameObject playerSprite;
    public GameObject PawWin;
    public GameObject JeffWin;
    public GameObject OttWin;
    public GameObject Ptar;
    public GameObject Jtar;
    public GameObject Odrum;

    public Canvas can;
    //public SpriteRenderer pRen;
    //public SpriteRenderer jRen;
    //public SpriteRenderer oRen;

    public AudioSource WinSfx;
    public AudioSource MenuMusic;
    public AudioSource JeffieMusic;
    public AudioSource PawsMusic;
    public AudioSource OttMusic;





    //Box in a list of strings

    void Awake()
    {
        RouteNum = 0;
        
        PawWin.SetActive(false);
        JeffWin.SetActive(false);
        OttWin.SetActive(false);
        AwsCheck = false;
        OttCheck = false;
        GeoffCheck = false;
        AllCheck = false;
        RouteButtons = GameObject.Find("PawstenButton" + "JeffieButton" + "OtterButton");
        //LeftAnsB = GameObject.Find("LeftAns");
        //RightAnsB = GameObject.Find("RightAns");
        // LeftAnsB.enabled = false;
        // RightAnsB.enabled = false;

        LeftAnsB.gameObject.SetActive(false);
        RightAnsB.gameObject.SetActive(false);
        TitleText.gameObject.SetActive(true);
        InstText.gameObject.SetActive(false);
        //pRen = GetComponent<SpriteRenderer>();
        //jRen = GetComponent<SpriteRenderer>();
        //oRen = GetComponent<SpriteRenderer>();
        
        QuestNum = 21;
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
        //Destroy(can);

        //Destroy(rootCanvas);

        //Destroy(QuestText);
        //Destroy(LeftText);
        //Destroy(EndingText);
        //Destroy(RightText);
        AwsRoute.onClick.AddListener(delegate { ChangeRoute(1); });
        GeoffRoute.onClick.AddListener(delegate { ChangeRoute(2); });
        OttRoute.onClick.AddListener(delegate { ChangeRoute(3); });
        mRestart.onClick.AddListener(ReturntoMenu);
        //LeftAnsB.onClick.AddListener();
        //RightAnsB.onClick.AddListener();
        Ptar.gameObject.SetActive(false);
        Jtar.gameObject.SetActive(false);
        Odrum.gameObject.SetActive(false);

        DontDestroyOnLoad(gameObject);
        //DontDestroyOnLoad(can);

        //DontDestroyOnLoad(RightText);
        //DontDestroyOnLoad(QuestText);
        //DontDestroyOnLoad(LeftText);
        //DontDestroyOnLoad(EndingText);


        //Instance = this;
    }

    void Start()
    {
        //MenuMusic.Play();
        //PawsMusic.Pause();
        //JeffieMusic.Pause();
        //OttMusic.Pause();

        if (RightText != null)
        {
            RightText.color = Color.black;

        }

        if (LeftText != null)
        {
            LeftText.color = Color.black;

        }
        
      

        AwsCheck = false;
        GeoffCheck = false;
        OttCheck = false;
        AllCheck = false;
        //RouteNum = 1;


    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (RouteNum == 0)
        {
            MenuMusic.Play();
            PawsMusic.Pause();
            JeffieMusic.Pause();
            OttMusic.Pause();
        }
        */
        if (BadAns > GoodAns)
        {
            ParkBG.SetActive(false);
        }
        else if (BadAns <= GoodAns)
        {
            ParkBG.SetActive(true);
        }
       
        
        Restart();
        if (Input.GetKeyDown(KeyCode.M))
        {
            GoodAns = 0;
            BadAns = 0;
            
            ReturntoMenu();
        }


        //if (Input.GetKey(KeyCode.RightArrow));
        //{
        // RightText.color = Color.cyan;
        //LeftText.color = Color.black;
        //Debug.Log("Right Works");
        //}
        //if (Input.GetKey(KeyCode.LeftArrow));
        //{
        //LeftText.color = Color.cyan;
        //RightText.color = Color.black;
        // Debug.Log("Left works");
        //}

        if (AwsCheck == true && GeoffCheck == true && OttCheck == true)
        {
            AllCheck = true;
        }

        /*if (AllCheck)
           
        {
            mRestartText.text = "!!!Congratulations!!!";
        }
*/


    }


    void ChangeRoute(int x)
    {
        MenuMusic.Pause();
        //Booleancheck();
        InstText.gameObject.SetActive(false);
        TitleText.gameObject.SetActive(false);

        AwsRoute.gameObject.SetActive(false);
        GeoffRoute.gameObject.SetActive(false);
        OttRoute.gameObject.SetActive(false);


        menuBG.SetActive(false);

        //LeftAnsB.enabled = true;
        //RightAnsB.enabled = true;
        LeftAnsB.gameObject.SetActive(true);
        RightAnsB.gameObject.SetActive(true);

        //TitleText.IsActive()=false; //might work likely not
        //Update I tested that and shocker it doesn;t work
        if (x == 1)
        {

            Debug.Log("Paws");
            PawsMusic.Play();
            PawsMusic.UnPause();
            JeffieMusic.Pause();
            OttMusic.Pause();
            InstText.gameObject.SetActive(false);
            TitleText.gameObject.SetActive(false);
            RouteNum = 1;
            QuestNum = 0;
            PAWSBG.SetActive(true);
            GeoffBG.SetActive(false);
            OttBG.SetActive(false);
        }

        else if (x == 2)
        {
            Debug.Log("Jeffie");
            PawsMusic.Pause();
            JeffieMusic.Play();
            JeffieMusic.UnPause();
            OttMusic.Pause();
            InstText.gameObject.SetActive(false);
            TitleText.gameObject.SetActive(false);
            RouteNum = 2;
            QuestNum = 7;
            PAWSBG.SetActive(false);
            GeoffBG.SetActive(true);
            OttBG.SetActive(false);
        }
        else if (x == 3)
        {
            Debug.Log("Otter");
            PawsMusic.Pause();
            JeffieMusic.Pause();
            OttMusic.Play();
            OttMusic.UnPause();
            InstText.gameObject.SetActive(false);
            TitleText.gameObject.SetActive(false);
            RouteNum = 3;
            QuestNum = 14;
            PAWSBG.SetActive(false);
            GeoffBG.SetActive(false);
            OttBG.SetActive(true);
        }
        else

        {
            Debug.Log("404 ROUTE NOT FOUND");
        }
    }

    void ButtonClicked()
    {
        RouteButtons.SetActive(false);
    }

    void Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            RouteNum = 0;
            QuestNum = 0;
            GoodAns = 0;
            BadAns = 0;
            PAWSBG.SetActive(false);
            GeoffBG.SetActive(false);
            OttBG.SetActive(false);
            LeftAnsB.gameObject.SetActive(false);
            RightAnsB.gameObject.SetActive(false);
            menuBG.SetActive(true);
            //SceneManager.LoadScene(0);
        }
    }

    void ReturntoMenu()
    {

        mRestart.gameObject.SetActive(false);
        playerSprite.SetActive(false);
        if (AllCheck)
        {
            
            PawsMusic.UnPause();
            JeffieMusic.Pause();
            OttMusic.Pause();
            WinSfx.Play();
            //Play FF Vic screen
            Ptar.gameObject.SetActive(false);
            Jtar.gameObject.SetActive(false);
            Odrum.gameObject.SetActive(false);

            GameManager.Instance.EndingText.gameObject.SetActive(true);
            WinBG.SetActive(true);
            PawWin.SetActive(true);
            JeffWin.SetActive(true);
            OttWin.SetActive(true);
            //add sprites
            PAWSBG.SetActive(false);
            GeoffBG.SetActive(false);
            OttBG.SetActive(false);
            //set EndSpritesTrue
            //Set Win text True
            AllCheck = false;
            InstText.gameObject.SetActive(false);
            TitleText.gameObject.SetActive(false);
            RouteNum = 0;
            QuestNum = 0;
            EndingText.text = Endings[6];
            EndingText.color = Color.green;
            EndingText.gameObject.SetActive(true);
            LeftAnsB.gameObject.SetActive(false);
            RightAnsB.gameObject.SetActive(false);
            playerSprite.SetActive(false);
            if (Input.GetKeyDown(KeyCode.R))
            {
                //SceneManager.LoadScene(0);
                AllCheck = false;
                Ptar.gameObject.SetActive(false);
                Jtar.gameObject.SetActive(false);
                Odrum.gameObject.SetActive(false);
                AwsRoute.onClick.AddListener(delegate { ChangeRoute(1); });
                GeoffRoute.onClick.AddListener(delegate { ChangeRoute(2); });
                OttRoute.onClick.AddListener(delegate { ChangeRoute(3); });
                RouteNum = 0;
                QuestNum = 0;
                AwsCheck = false;
                OttCheck = false;
                GeoffCheck = false;
                AllCheck = false;
                AwsRoute.gameObject.SetActive(true);
                AwsRoute.enabled = true;
                AwsRoute.interactable = true;
                GeoffRoute.gameObject.SetActive(true);
                GeoffRoute.enabled = true;
                GeoffRoute.interactable = true;
                OttRoute.gameObject.SetActive(true);
                OttRoute.enabled = true;
                OttRoute.interactable = true;
                menuBG.SetActive(true);
                InstText.gameObject.SetActive(false);
                TitleText.gameObject.SetActive(true);
                RouteNum = 0;
                QuestNum = 0;
                EndingText.gameObject.SetActive(false);
                LeftAnsB.gameObject.SetActive(false);
                RightAnsB.gameObject.SetActive(false);
                
                Booleancheck();

                Awake();
                Start();

            }
        }



        else if (GoodAns > BadAns)
        {
            playerSprite.SetActive(true);
            
            menuBG.SetActive(true);
            InstText.gameObject.SetActive(false);
            TitleText.gameObject.SetActive(true);
            RouteNum = 0;
            QuestNum = 0;
            EndingText.gameObject.SetActive(false);
            LeftAnsB.gameObject.SetActive(false);
            RightAnsB.gameObject.SetActive(false);
            Ptar.gameObject.SetActive(false);
            Jtar.gameObject.SetActive(false);
            Odrum.gameObject.SetActive(false);
            Booleancheck();
            
            




        }
        else if (BadAns >= GoodAns)
        {
            playerSprite.SetActive(true);
            AwsCheck = false;
            OttCheck = false;
            GeoffCheck = false;
            AllCheck = false;
            menuBG.SetActive(true);
            InstText.gameObject.SetActive(false);
            TitleText.gameObject.SetActive(true);
            RouteNum = 0;
            QuestNum = 0;
            GoodAns = 0;
            BadAns = 0;
            EndingText.gameObject.SetActive(false);
            LeftAnsB.gameObject.SetActive(false);
            RightAnsB.gameObject.SetActive(false);
            Ptar.gameObject.SetActive(false);
            Jtar.gameObject.SetActive(false);
            Odrum.gameObject.SetActive(false);
        
            Booleancheck(); 
        }
        



    }


void Booleancheck()
    {
        
        // awsCheck

        if (AwsCheck)
        {
            AwsRoute.gameObject.SetActive(false);
            AwsRoute.enabled = false;
            AwsRoute.interactable = false;
            Ptar.gameObject.SetActive(true);
            
            
        }
        else
        {
            AwsRoute.onClick.AddListener(delegate { ChangeRoute(1); });
            AwsRoute.gameObject.SetActive(true);
            AwsRoute.enabled = true;
            AwsRoute.interactable = true;
            Ptar.gameObject.SetActive(false);
        }
        
        //geoffCheck

        if (GeoffCheck)
        {
            GeoffRoute.gameObject.SetActive(false);
            GeoffRoute.enabled = false;
            GeoffRoute.interactable = false;
            Jtar.gameObject.SetActive(true);
        }
        else
        {
            
            GeoffRoute.onClick.AddListener(delegate { ChangeRoute(2); });
            
            GeoffRoute.gameObject.SetActive(true);
            GeoffRoute.enabled = true;
            GeoffRoute.interactable = true;
            Jtar.gameObject.SetActive(false);
        }
        
        //ottCheck

        if (OttCheck)
        {
            OttRoute.gameObject.SetActive(false);
            OttRoute.enabled = false;
            OttRoute.interactable = false;
            Odrum.gameObject.SetActive(true);
        }
        else
        {
            OttRoute.onClick.AddListener(delegate { ChangeRoute(3); });
            OttRoute.gameObject.SetActive(true);
            OttRoute.enabled = true;
            OttRoute.interactable = true;
            Odrum.gameObject.SetActive(false);
        }
        
        /*
        if (AwsCheck)
        {
            AwsRoute.gameObject.SetActive(false);
            if (GeoffCheck == true)
            {
                GeoffRoute.gameObject.SetActive(false);
                if (OttCheck == true)
                {
                    OttRoute.gameObject.SetActive(false);  
                }
                else if (OttCheck == false)
                {
                    OttRoute.gameObject.SetActive(true);
                }
            }
            else if (GeoffCheck == false)
            {
                GeoffRoute.gameObject.SetActive(true);
                if (OttCheck == true)
                {
                    OttRoute.gameObject.SetActive(false);  
                }
                else if (OttCheck == false)
                {
                    OttRoute.gameObject.SetActive(true);
                }
            }
        }
        else if (AwsCheck == false)
        {
            AwsRoute.gameObject.SetActive(true);
            if (GeoffCheck == true)
            {
                GeoffRoute.gameObject.SetActive(false);
                if (OttCheck == true)
                {
                    OttRoute.gameObject.SetActive(false);  
                }
                else if (OttCheck == false)
                {
                    OttRoute.gameObject.SetActive(true);
                }
            }
            else if (GeoffCheck == false)
            {
                GeoffRoute.gameObject.SetActive(true);
                if (OttCheck == true)
                {
                    OttRoute.gameObject.SetActive(false);  
                }
                else if (OttCheck == false)
                {
                    OttRoute.gameObject.SetActive(true);
                }
            }
        }
        else
        {
            Debug.Log("ERRRROR");
        } */
    } 
    
}
//hide title