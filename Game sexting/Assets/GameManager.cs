using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour {

    private static int ListIndex = 0;
    private bool firstButton = false;
    private bool secondButton = false;
    private int questionNumber = 0;

    void Start()
    {

    }

    void SetCurrentQuestion(int listIndex)
    {

        //switch (listIndex)
        //{
        //    case 1:
        //        if (firstButton == true)
        //        {
        //            Debug.Log("switch first button");
        //        }
        //        if (secondButton == true)
        //        {
        //            Debug.Log("switch second button");
        //        }
        //        break;
        //    case 2:
        //        if (firstButton == true)
        //        {
        //            Debug.Log("switch first button second question");
        //        }
        //        if (secondButton == true)
        //        {
        //            Debug.Log("switch second button second question");
        //        }
        //        break;
        //    default:
        //        break;
        //}


        firstButton = false;
        secondButton = false;
    }

    public void UserSelectFirstButton(int num)
    {
        Debug.Log("First Button");
        firstButton = true;
        questionNumber = num;
    }

    public void UserSelectSecondButton(int num)
    {
        Debug.Log("Second Button");
        firstButton = true;
        questionNumber = num;
    }
}
