using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour {

    public enum colors {Grey, Green, Orange, Red};
    public byte currentColor;
    Color schoolColor;
    Color orange;

    float percentage;

    public float spreadFactor;
    public float tempNbrOfReachedStudents;

    public School[] otherSchools = new School[4];
    public ushort nbrOfStudents;
    public ushort nbrOfReachedStudents; //The number of students of the school that recieved the picture
    public bool isInfected = false;

    void start()
    {
        orange = new Color(0.2F, 0.3F, 0.4F);
        isInfected = false;
        nbrOfReachedStudents = 0;
        spreadFactor = 1;
    }

    public void ChangeAppearence()
    {
        Spread();
        CalculatePercentage();
        CalculateColor();
        SpreadToOtherSchools();
    }

    public void CalculateColor()
    {
        schoolColor = new Color();
        float percentage = CalculatePercentage();

        if (!isInfected)
        {
            currentColor = (byte)colors.Grey; //If the school isn't effected it get's the color grey
        }
        else
        {
            if(percentage <= 0.33)
            {
                currentColor = (byte)colors.Green;
            }
            else if(percentage <= 0.66)
            {
                currentColor = (byte)colors.Orange;
            }
            else
            {
                currentColor = (byte)colors.Red;
            }
        }
        //Debug.Log(currentColor);
        ChangeColor();
    } //Calculates the color of the school

    public void ChangeColor()
    {
         switch(currentColor)
        {
            case 0:
                schoolColor = Color.gray;
                break;
            case 1:
                schoolColor = Color.green;
                break;
            case 2:
                schoolColor.r = 1;
                schoolColor.g = 0.5f;
                schoolColor.b = 0;
                schoolColor.a = 1;
                break;
            case 3:
                schoolColor = Color.red;
                break;
            default:
                break;
        }
        gameObject.GetComponent<SpriteRenderer>().color = schoolColor;
    }

    public float CalculatePercentage()
    {
        percentage = (float)((float)nbrOfReachedStudents / (float)nbrOfStudents);

        return percentage;
    } //Calculates teh percentage of students that recieved the picture

    public void Spread()
    {
        if (nbrOfReachedStudents < nbrOfStudents && isInfected == true)
        {
            tempNbrOfReachedStudents += (nbrOfReachedStudents / 16);
            tempNbrOfReachedStudents *= spreadFactor;
            if(tempNbrOfReachedStudents >= 1)
            {
                nbrOfReachedStudents += (ushort)Mathf.Round(tempNbrOfReachedStudents);
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
        if(newRandomNumber < nbrOfReachedStudents)
        {
            newRandomNumber = (ushort)Random.Range(0, 4);

            if(otherSchools[newRandomNumber].isInfected == false)
            {
                otherSchools[newRandomNumber].nbrOfReachedStudents = 1;
                otherSchools[newRandomNumber].tempNbrOfReachedStudents = 1;
                otherSchools[newRandomNumber].isInfected = true;
            }
        }
    } //Spreads to other schools
}

    
