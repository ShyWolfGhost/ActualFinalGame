using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    
    // Start is called before the first frame update

    
    //public Sprite pPaw;
    //public Sprite jPaw;
    //public Sprite oPaw;
    
    
    
    
    
    
    
    void Start()
    {
        
        //GameManager.Instance.pRen.sprite = pPaw;
        //GameManager.Instance.jRen.sprite = jPaw;
        //GameManager.Instance.oRen.sprite = oPaw;
        
        if (GameManager.Instance.RouteNum == 0)
        {
            GameManager.Instance.QuestNum = 0;
            //GameManager.Instance.pRen.enabled = true;
            //GameManager.Instance.jRen.enabled = true;
            //GameManager.Instance.oRen.enabled = true;
            
            GameManager.Instance.TitleText.text = "So You Want To Join MeowderSlides?";
            GameManager.Instance.InstText.text = "Press 1 for Pawsten\nPress 2 for Jeffie\nPress 3 for Otter";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Debug.Log( "ROUTE NUM: " + GameManager.Instance.RouteNum.ToString());
       
        if (Input.GetKeyDown(KeyCode.Alpha1)&&GameManager.Instance.RouteNum==0 )
                 {
                     //GameManager.Instance.pRen.enabled = false;
                     //GameManager.Instance.jRen.enabled = false;
                     //GameManager.Instance.oRen.enabled = false;
                     GameManager.Instance.TitleText.text = "";
                     GameManager.Instance.InstText.text = "";
                     GameManager.Instance.RouteNum = 1;
                     GameManager.Instance.QuestNum = 0;
                     Debug.Log("AWS");
                     
                         
                     
                 }
        else if (Input.GetKeyDown(KeyCode.Alpha1)&&GameManager.Instance.RouteNum > 0)
        {
            Debug.Log("You tried");



        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)&&GameManager.Instance.RouteNum==0 )
        {
            //GameManager.Instance.pRen.enabled = false;
            //GameManager.Instance.jRen.enabled = false;
            //GameManager.Instance.oRen.enabled = false;
            GameManager.Instance.TitleText.text = "";
            GameManager.Instance.InstText.text = "";
            GameManager.Instance.RouteNum = 2;
            GameManager.Instance.QuestNum = 7; 
            Debug.Log("GEOFF");
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && GameManager.Instance.RouteNum > 0)
        {
            Debug.Log("You tried");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3)&&GameManager.Instance.RouteNum==0)
        {
            //GameManager.Instance.pRen.enabled = false;
            //GameManager.Instance.jRen.enabled = false;
            //GameManager.Instance.oRen.enabled = false;
            GameManager.Instance.TitleText.text = "";
            GameManager.Instance.InstText.text = "";
            GameManager.Instance.RouteNum = 3;
            GameManager.Instance.QuestNum = 14;
            Debug.Log("OTT");
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && GameManager.Instance.RouteNum > 0)
        {
            Debug.Log("You tried");
        }
    }
}
