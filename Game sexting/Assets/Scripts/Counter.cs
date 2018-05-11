using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public School[] schools = new School[5];
    public Text UICounter;
    public Text[] UIMiniCounters = new Text[5];
    public ushort totalNbrOfInfectedStudents;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        totalNbrOfInfectedStudents = 0;

		for(int i = 0; i < schools.Length; i++)
        {
            totalNbrOfInfectedStudents += schools[i].nbrOfReachedStudents;
            UIMiniCounters[i].text = schools[i].nbrOfReachedStudents.ToString();
        }

        UpdateUI();
	}
    
    void UpdateUI()
    {
        UICounter.text = totalNbrOfInfectedStudents.ToString();
    }
}
