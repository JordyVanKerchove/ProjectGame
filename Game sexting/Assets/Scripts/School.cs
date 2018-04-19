using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour {

    public School[] otherSchools = new School[5];
    public ushort nbrOfStudents;
    public ushort nbrOfReachedStudents; //The number of students of the school that recieved the picture
    public bool isInfected = false;

    void Update()
    {
        Spread();
        CalculateColor();
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
            schoolColor = new Vector4(percentage, 1 - percentage, 0, 0.5f); //If the school is effected it get's a color from green to red
            this.GetComponent<Renderer>().material.color = schoolColor;
        }
    } //Calculates the color of the school

    public float CalculatePercentage()
    {
        float percentage;

        percentage = (float)((float)nbrOfReachedStudents / (float)nbrOfStudents);

        return percentage;
    } //Calculates teh percentage of students that recieved the picture

    public void Spread()
    {
        if (nbrOfReachedStudents < nbrOfStudents && isInfected == true)
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
            newRandomNumber = (ushort)Random.Range(0, 5);

            if(otherSchools[newRandomNumber].isInfected == false)
            {
                otherSchools[newRandomNumber].nbrOfReachedStudents = 1;
                otherSchools[newRandomNumber].isInfected = true;
            }
        }
    } //Spreads to other schools
}

    
