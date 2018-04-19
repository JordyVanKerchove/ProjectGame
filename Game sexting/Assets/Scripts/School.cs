using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour {

    public School otherSchool;
    public ushort nbrOfStudents;
    public ushort nbrOfReachedStudents; //The number of students of the school that recieved the picture
    public bool isInfected = false;

    void Update()
    {
        Spread();
        CalculateColor();
        SpreadToOtherSchools();
        System.Threading.Thread.Sleep(1000);
    }

    public void CalculateColor()
    {
        Color schoolColor = new Color();
        float percentage = CalculatePercentage();

        if (!isInfected)
        {
            this.GetComponent<Renderer>().material.color = Color.grey; //If the school isn't effected it get's the color grey
        }
        else
        {
            if(percentage < 0.5)
            {
                schoolColor = new Vector4(percentage * 2, 1 - percentage * 0.66f, 0, 0.5f); //If the school is effected it get's a color from green to red
                this.GetComponent<Renderer>().material.color = schoolColor;
            }
            else if (percentage > 0.5 && percentage <= 1)
            {
                schoolColor = new Vector4(1, 1 - percentage, 0, 0.5f); //If the school is effected it get's a color from green to red
                this.GetComponent<Renderer>().material.color = schoolColor;
            }
        }
    } //Calculates the color of the school

    public float CalculatePercentage()
    {
        float percentage;

        percentage = (float)((float)nbrOfReachedStudents / (float)nbrOfStudents);

        return percentage;
    } //Calculates the percentage of students that recieved the picture

    public void Spread()
    {
        if (nbrOfReachedStudents < nbrOfStudents)
        {
            if(nbrOfReachedStudents % 2 == 0)
            {
                nbrOfReachedStudents += (ushort)(nbrOfReachedStudents / 2);
            }
            else
            {
                nbrOfReachedStudents += (ushort)((nbrOfReachedStudents + 1) / 2);
            }

            if (nbrOfReachedStudents >= nbrOfStudents)
            {
                nbrOfReachedStudents = nbrOfStudents;
            }

        }
    } //Spreads in this school

    public void SpreadToOtherSchools()
    {
        ushort newRandomNumber = (ushort)Random.Range(0, nbrOfStudents);
        if(newRandomNumber > nbrOfReachedStudents)
        {
            if(otherSchool.isInfected == false)
            {
                otherSchool.nbrOfReachedStudents = 1;
            }
        }
    } //Spreads to other schools
}

    
