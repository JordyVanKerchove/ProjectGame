using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Counter : MonoBehaviour {

    public School[] schools = new School[5];
    public Text UICounter;
    public Text[] UIMiniCounters = new Text[5];
    public ushort totalNbrOfReachedStudents;
    public ushort totalNbrOfStudents;
    public float totalPercent;
    float tempPercent;

    // Use this for initialization
    void Start ()
    {
        totalPercent = 0;
        totalNbrOfStudents = 0;

        for (int i = 0; i < schools.Length; i++)
        {
            totalNbrOfStudents += schools[i].nbrOfStudents;
        }
    }
	
	// Update is called once per frame
	void Update () {
        totalNbrOfReachedStudents = 0;

		for(int i = 0; i < schools.Length; i++)
        {
            tempPercent = 0;
            totalNbrOfReachedStudents += schools[i].nbrOfReachedStudents;
            tempPercent = schools[i].nbrOfReachedStudents * 100;
            tempPercent /= schools[i].nbrOfStudents;
            tempPercent = (float)Math.Round(tempPercent);
            UIMiniCounters[i].text = tempPercent + "%";
        }
        totalPercent = totalNbrOfReachedStudents * 100;
        totalPercent /= totalNbrOfStudents;
        totalPercent = (float)Math.Round(totalPercent);

        UpdateUI();
	}
    
    void UpdateUI()
    {
        UICounter.text = totalPercent.ToString() + "%";
    }
}
