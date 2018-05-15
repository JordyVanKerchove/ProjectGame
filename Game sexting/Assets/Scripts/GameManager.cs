using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Timer timer;
    public bool mustStop;

    private bool firstButton = false;
    private bool secondButton = false;
    private int questionNumber = 0; 

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;
    public GameObject panel8;
    public GameObject panel9;
    public GameObject panel10;
    public GameObject endPanel;
    public GameObject tipsScherm;
    public GameObject hulpScherm;

    public GameObject storyPanel1;
    public GameObject storyPanel2A;
    public GameObject storyPanel2B;
    public GameObject storyPanel3A;
    public GameObject storyPanel3B;
    public GameObject storyPanel4A;
    public GameObject storyPanel4B;
    public GameObject storyPanel5A;
    public GameObject storyPanel5B;
    public GameObject storyPanel6A;
    public GameObject storyPanel6B;
    public GameObject storyPanel7A;
    public GameObject storyPanel7B;
    public GameObject storyPanel8A;
    public GameObject storyPanel8B;
    public GameObject storyPanel9A;
    public GameObject storyPanel9B;
    public GameObject storyPanel10A;
    public GameObject storyPanel10B;
    public GameObject storyPanel11A;
    public GameObject storyPanel11B;

    public School[] schools = new School[5];

    void Start()
    {
        // sets all panels to false and the beginning panel as true at the start of the game 
       
        storyPanel1.SetActive(true);
        storyPanel2A.SetActive(false);
        storyPanel2B.SetActive(false);
        storyPanel3A.SetActive(false);
        storyPanel3B.SetActive(false);
        storyPanel4A.SetActive(false);
        storyPanel4B.SetActive(false);
        storyPanel5A.SetActive(false);
        storyPanel5B.SetActive(false);
        storyPanel6A.SetActive(false);
        storyPanel6B.SetActive(false);
        storyPanel7A.SetActive(false);
        storyPanel7B.SetActive(false);
        storyPanel8A.SetActive(false);
        storyPanel8B.SetActive(false);
        storyPanel9A.SetActive(false);
        storyPanel9B.SetActive(false);
        storyPanel10A.SetActive(false);
        storyPanel10B.SetActive(false);
        storyPanel11A.SetActive(false);
        storyPanel11B.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        panel7.SetActive(false);
        panel8.SetActive(false);
        panel9.SetActive(false);
        panel10.SetActive(false);
    }  

    void Update()
    {
        switch (timer.nbrOfDays)
        {
            case 7:
                if (mustStop)
                {
                    panel1.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 14:
                if (mustStop)
                {
                    panel2.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 21:
                if (mustStop)
                {
                    panel3.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 28:
                if (mustStop)
                {
                    panel4.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 35:
                if (mustStop)
                {
                    panel5.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 42:
                if (mustStop)
                {
                    panel6.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 49:
                if (mustStop)
                {
                    panel7.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 56:
                if (mustStop)
                {
                    panel8.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 63:
                if (mustStop)
                {
                    panel9.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            case 70:
                if (mustStop)
                {
                    panel10.SetActive(true);
                    PauseSchools();
                    mustStop = false;
                }
                break;
            default:
                mustStop = true;
                break;
        }
    }

    void SetCurrentQuestion()
    {

        switch (questionNumber)
        {
            case 1:
                panel1.SetActive(false); // zet panel 1 uit
                
                if (firstButton == true && secondButton == false) // bovenste knop vraag 1
                {
                    Debug.Log("switch first button vraag 1");
                    storyPanel2A.SetActive(true);
                    schools[0].spreadFactor -= 0.25f;
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 1 
                {
                    Debug.Log("switch second button vraag 1");
                    storyPanel2B.SetActive(true);
                    changeSpreadFactor(0);
                }
                break;

            case 2:
                panel2.SetActive(false); // zet panel 2 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 2
                {
                    Debug.Log("switch first button vraag 2");
                    storyPanel3A.SetActive(true);
                    changeSpreadFactor(0.2f);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 2
                {
                    Debug.Log("switch second button vraag 2");
                    storyPanel3B.SetActive(true);
                    changeSpreadFactor(0);
                }
                break;

            case 3:
                panel3.SetActive(false); // zet panel 3 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 3
                {
                    Debug.Log("switch first button vraag 3");
                    storyPanel4A.SetActive(true);
                    changeSpreadFactor(0);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 3
                {
                    Debug.Log("switch second button vraag 3");
                    storyPanel4B.SetActive(true);
                    changeSpreadFactor(-0.1f);
                }
                break;

            case 4:
                panel4.SetActive(false); // zet panel 4 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 4
                {
                    Debug.Log("switch first button vraag 4");
                    storyPanel5A.SetActive(true);
                    changeSpreadFactor(-0.1f);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 4
                {
                    Debug.Log("switch second button vraag 4");
                    storyPanel5B.SetActive(true);
                    changeSpreadFactor(0.1f);
                }

                break;

            case 5:
                panel5.SetActive(false); // zet panel 5 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 5
                {
                    Debug.Log("switch first button vraag 5");
                    storyPanel6A.SetActive(true);
                    changeSpreadFactor(0.4f);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 5
                {
                    Debug.Log("switch second button vraag 5");
                    storyPanel6B.SetActive(true);
                    changeSpreadFactor(0);
                }
                
                break;

            case 6:
                panel6.SetActive(false); // zet panel 6 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 6
                {
                    Debug.Log("switch first button vraag 6");
                    storyPanel7A.SetActive(true);
                    changeSpreadFactor(0);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 6
                {
                    Debug.Log("switch second button vraag 6");
                    storyPanel7B.SetActive(true);
                    changeSpreadFactor(0.2f);
                }
                
                break;

            case 7:
                panel7.SetActive(false); // zet panel 7 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 7
                {
                    Debug.Log("switch first button vraag 7");
                    storyPanel8A.SetActive(true);
                    changeSpreadFactor(0.2f);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 7
                {
                    Debug.Log("switch second button vraag 7");
                    storyPanel8B.SetActive(true);
                    changeSpreadFactor(0);
                }
                
                break;

            case 8:
                panel8.SetActive(false); // zet panel 8 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 8
                {
                    Debug.Log("switch first button vraag 8");
                    storyPanel9A.SetActive(true);
                    changeSpreadFactor(0);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 8
                {
                    Debug.Log("switch second button vraag 8");
                    storyPanel9B.SetActive(true);
                    changeSpreadFactor(0);
                }

                break;

            case 9:
                panel9.SetActive(false); // zet panel 9 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 9
                {
                    Debug.Log("switch first button vraag 9");
                    storyPanel10A.SetActive(true);
                    changeSpreadFactor(0);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 9
                {
                    Debug.Log("switch second button vraag 9");
                    storyPanel10B.SetActive(true);
                    changeSpreadFactor(0);
                }
                
                break;

            case 10:
                panel10.SetActive(false);  // zet panel 10 uit
                if (firstButton == true && secondButton == false) // bovenste knop vraag 10
                {
                    Debug.Log("switch first button vraag 10");
                    storyPanel11A.SetActive(true);
                    changeSpreadFactor(0);
                }
                if (secondButton == true && firstButton == false) // onderste knop vraag 10
                {
                    Debug.Log("switch second button vraag 10");
                    storyPanel11B.SetActive(true);
                    changeSpreadFactor(0);
                }
                
                break;

            default:
                Debug.Log("Not able to select a switch case!");
                break;
        }

        firstButton = false;
        secondButton = false;
    }

    public void UserSelectFirstButton(int num)
    {
        firstButton = true;
        questionNumber = num; // mee gegeven nummer van de vraag uit unity;
        SetCurrentQuestion();
    }

    public void UserSelectSecondButton(int num)
    {
        secondButton = true;
        questionNumber = num; // mee gegeven nummer van de vraag uit unity;
        SetCurrentQuestion();
    }


    // IF "Volgende" is clicked on one of these panels.

    public void IfStoryPanel1()
    {
        storyPanel1.SetActive(false);

        RestartSchools();
        //panel1.SetActive(true);
    }

    public void IfStoryPanel2()
    {
        storyPanel2A.SetActive(false);
        storyPanel2B.SetActive(false);

        RestartSchools();
        //panel2.SetActive(true);
    }

    public void IfStoryPanel3()
    {
        storyPanel3A.SetActive(false);
        storyPanel3B.SetActive(false);

        RestartSchools();
        //panel3.SetActive(true);
    }

    public void IfStoryPanel4()
    {
        storyPanel4A.SetActive(false);
        storyPanel4B.SetActive(false);

        RestartSchools();
        //panel4.SetActive(true);
    }

    public void IfStoryPanel5()
    {
        storyPanel5A.SetActive(false);
        storyPanel5B.SetActive(false);

        RestartSchools();
        //panel5.SetActive(true);
    }

    public void IfStoryPanel6()
    {
        storyPanel6A.SetActive(false);
        storyPanel6B.SetActive(false);

        RestartSchools();
        //panel6.SetActive(true);
    }

    public void IfStoryPanel7()
    {
        storyPanel7A.SetActive(false);
        storyPanel7B.SetActive(false);

        RestartSchools();
        //panel7.SetActive(true);
    }

    public void IfStoryPanel8()
    {
        storyPanel8A.SetActive(false);
        storyPanel8B.SetActive(false);

        RestartSchools();
        //panel8.SetActive(true);
    }

    public void IfStoryPanel9()
    {
        storyPanel9A.SetActive(false);
        storyPanel9B.SetActive(false);

        RestartSchools();
        //panel9.SetActive(true);
    }

    public void IfStoryPanel10()
    {
        storyPanel10A.SetActive(false);
        storyPanel10B.SetActive(false);

        RestartSchools();
        //panel10.SetActive(true);
    }

    public void IfStoryPanel11()
    {
        storyPanel11A.SetActive(false);
        storyPanel11B.SetActive(false);

        endPanel.SetActive(true);
        
        //endPanel.SetActive(true);
    }

    public void ifEindwoord()
    {
        endPanel.SetActive(false);
        tipsScherm.SetActive(true);
    }

    public void ifTips()
    {
        tipsScherm.SetActive(false);
        hulpScherm.SetActive(true);
    }

    public void ifHulpscherm()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseSchools()
    {
        timer.isPaused = true;
    }

    public void RestartSchools()
    {
        timer.isPaused = false;
    }

    public void changeSpreadFactor(float initFactorDifference)
    {
        for(int i = 0; i < schools.Length; i++)
        {
            schools[i].spreadFactor += initFactorDifference;
        }
    }
}
