﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class School : MonoBehaviour {

    public enum colors {Grey, Green, Orange, Red};
    public byte currentColor;
    Color schoolColor;
    //Color orange;

    float percentage;

    public float spreadFactor;
    public float tempNbrOfReachedStudents;
    public float newTempNbrOfStudents;

    public School[] otherSchools = new School[4];
    public ushort nbrOfStudents;
    public ushort nbrOfReachedStudents; //The number of students of the school that recieved the picture
    public bool isInfected = false;

    void start()
    {
        //orange = new Color(0.2F, 0.3F, 0.4F, 1);
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
        float tempPercentage = 0;

        if (!isInfected)
        {
            schoolColor = new Color(0.5F, 0.5F, 0.5F); //If the school isn't effected it get's the color grey
        }
        else
        {
            /*if(percentage <= 0.33) // methoder 1
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
            }*/

            /*if(percentage < 0.5) // methoder 2
            {
                schoolColor = new Color(0 + percentage * 4, 1 - percentage * 14, 0 + percentage * 8);
            }
            else
            {
                schoolColor = new Color(0.2F + (percentage - 0.5F) * 16, 0.3F - (percentage - 0.5f) * 6, 0.4F - (percentage - 0.5F) * 8);
            }*/

            // methoder 3
            if (percentage < 0.5)
            {
                tempPercentage = percentage * 2;
                schoolColor = Color.Lerp(new Color(0, 1, 0, 1), new Color(1, 0.5F, 0, 1), tempPercentage);
            }
            else
            {
                tempPercentage = (percentage - 0.5F) * 2;
                schoolColor = Color.Lerp(new Color(1, 0.5F, 0, 1), new Color(1, 0, 0, 1),tempPercentage);
            }
        }
        //Debug.Log(currentColor);
        ChangeColor();
    } //Calculates the color of the school

    public void ChangeColor()
    {
         /*switch(currentColor)
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
        }*/
        gameObject.GetComponent<Image>().color = schoolColor;
    }

    public float CalculatePercentage()
    {
        percentage = (float)((float)nbrOfReachedStudents / (float)nbrOfStudents);

        return percentage;
    } //Calculates teh percentage of students that recieved the picture

    public void Spread()
    {
        if (spreadFactor < 0)
        {
            spreadFactor = 0;
        }
        if (nbrOfReachedStudents < nbrOfStudents && isInfected == true)
        {
            newTempNbrOfStudents = nbrOfReachedStudents / 30;
            newTempNbrOfStudents *= spreadFactor;
            tempNbrOfReachedStudents += newTempNbrOfStudents;
            if(tempNbrOfReachedStudents >= 1)
            {
                nbrOfReachedStudents += (ushort)Mathf.Round(tempNbrOfReachedStudents);
            }
            else
            {
                nbrOfReachedStudents++;
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

    
