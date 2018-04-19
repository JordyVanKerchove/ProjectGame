using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

    public DateTime startTime;
    public DateTime currentTime;
    public Text TimerText;

	// Use this for initialization
	void Start () {
        startTime = DateTime.Now;
        currentTime = startTime;

        UpdateUI();
        System.Threading.Thread.Sleep(1000);
	}
	
	// Update is called once per frame
	void Update () {
        currentTime = currentTime.AddDays(1);
        UpdateUI();

        System.Threading.Thread.Sleep(1000);
    }

    void UpdateUI()
    {
        TimerText.text = String.Format("{0:dd-MM-yyyy}", currentTime);
    }
}
