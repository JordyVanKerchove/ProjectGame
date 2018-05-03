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
    
	// Use this for initialization
	void Start () {
        nbrOfDays = 0;
        startDate = DateTime.Now;
        currentDate = startDate;

        StartCoroutine(Sleep1Sec());
        
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    IEnumerator Sleep1Sec()
    {
        for (int i = 0; i < 500; i++)
        {
            UpdateUI();
            UpdateSchools();
            yield return new WaitForSeconds(1f);
            currentDate = currentDate.AddDays(1);
            nbrOfDays++;
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
