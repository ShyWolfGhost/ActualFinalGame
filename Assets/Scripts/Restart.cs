using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }
    public void RestartGame()
    {
        GameManager.Instance.QuestNum = 0;
        GameManager.Instance.GoodAns = 0;
        GameManager.Instance.BadAns = 0;
        GameManager.Instance.AwsCheck = false;
        GameManager.Instance.OttCheck = false;
        GameManager.Instance.GeoffCheck = false;
        GameManager.Instance.AllCheck = false;
        //GameManager.Instance.pRen.enabled = true;
        //GameManager.Instance.jRen.enabled = true;
        //GameManager.Instance.oRen.enabled = true;
        GameManager.Instance.ColorNum = 0;
        //Sren.sprite = starter;
        //GameManager.Instance.EndingText.text=" ";
        GameManager.Instance.RouteNum = 0;
        SceneManager.LoadScene("Pawstens Route");
        GameManager.Instance.QuestText.text = " ";
        GameManager.Instance.EndingText.text = " ";
        GameManager.Instance.TitleText.text = "So You Want To Join MeowderSlides?";
        GameManager.Instance.InstText.text = "Press 1 for Pawsten\nPress 2 for Jeffie\nPress 3 for Otter";

        
    }
}
