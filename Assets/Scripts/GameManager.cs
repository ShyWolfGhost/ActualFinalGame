using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    //in ref to buttons
    public GameObject allButtons;
    public Button AwsRoute;
    public Button GeoffRoute;
    public Button OttRoute;

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
    //make moer backgrounds


    public Canvas can;
    //public SpriteRenderer pRen;
    //public SpriteRenderer jRen;
    //public SpriteRenderer oRen;





    //Box in a list of strings

    void Awake()
    {
        //pRen = GetComponent<SpriteRenderer>();
        //jRen = GetComponent<SpriteRenderer>();
        //oRen = GetComponent<SpriteRenderer>();
        RouteNum = 0;
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



    }

    void ChangeRoute(int x)
    {
        AwsRoute.enabled = false;
        menuBG.SetActive(false);
        allButtons.SetActive(false);
        TitleText.color = Color.grey; //might work likely not
        //Update I tested that and shocker it doesn;t work
        if (x == 1)
        {
            Debug.Log("Paws");
            RouteNum = 1;
            QuestNum = 0;
            PAWSBG.SetActive(true);
            GeoffBG.SetActive(false);
            OttBG.SetActive(false);
        }

        else if  (x == 2)
        {
            Debug.Log("Jeffie");
            RouteNum = 2;
            QuestNum = 7;
            PAWSBG.SetActive(false);
            GeoffBG.SetActive(true);
            OttBG.SetActive(false);
        }
        else if (x == 3)
        {
            Debug.Log("Otter");
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
}
