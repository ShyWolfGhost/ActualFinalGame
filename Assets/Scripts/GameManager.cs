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

        if (RightText != null )
        {
            RightText.color = Color.black;

        }

        if (LeftText != null)
        {
            LeftText.color = Color.black;

        }
        AwsCheck = false;
        GeoffCheck=false;
        OttCheck=false;
        AllCheck =false;
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
}
