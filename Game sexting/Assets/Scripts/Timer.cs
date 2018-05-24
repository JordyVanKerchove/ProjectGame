using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public School[] schools = new School[5]; 

    DateTime startDate;
    DateTime currentDate;
    public Text UITimer;
    public ushort nbrOfDays;

    public bool isPaused;
    public bool coRoutineIsRunning;
    
	// Use this for initialization
	void Start () {
        nbrOfDays = 0;
        startDate = DateTime.Now;
        currentDate = startDate;

        isPaused = true;
        coRoutineIsRunning = true;

        StartCoroutine(Sleep1Sec());
    }
	
	// Update is called once per frame
	void Update () {
       if (!coRoutineIsRunning)
        {
            StartCoroutine(Sleep1Sec());
        }
	}

    IEnumerator Sleep1Sec()
    {
        coRoutineIsRunning = true;
        //for (int i = 0; i < 500; i++)
        {
            Debug.Log(isPaused);
            if (!isPaused)
            {
                UpdateUI();
                UpdateSchools();
                yield return new WaitForSeconds(1f);
                currentDate = currentDate.AddDays(1);
                nbrOfDays++;
            }
            coRoutineIsRunning = false;
        }
    }

    void UpdateUI()
    {
        UITimer.text = String.Format("{0:dd-MM-yyyy}", currentDate);
    }

    void UpdateSchools()
    {
        for(int i = 0; i < schools.Length; i++)
        {
            schools[i].ChangeAppearence();
        }
    }
}
