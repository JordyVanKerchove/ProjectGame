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
    
	// Use this for initialization
	void Start () {
        startDate = DateTime.Now;
        currentDate = startDate;
	}
	
	// Update is called once per frame
	void Update () {
        UpdateUI();
        UpdateSchools();

        System.Threading.Thread.Sleep(1000);


        currentDate = currentDate.AddDays(1);
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
