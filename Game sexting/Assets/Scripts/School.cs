using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour {

    public ushort nbrOfStudents;
    public ushort nbrOfReachedStudents;

    void Update()
    {
        CalculateColor();
    }

    public void CalculateColor()
    {
        Debug.Log(CalculatePercentage());
        Color schoolColor = new Color();
        float percentage = CalculatePercentage();

        if (percentage == 0)
        {
            this.GetComponent<Renderer>().material.color = Color.grey;
        }
        else
        {
            schoolColor = new Vector4(percentage, 1 - percentage, 0, 0.5f);
            this.GetComponent<Renderer>().material.color = schoolColor;
        }
    }

    public float CalculatePercentage()
    {
        float percentage;

        percentage = (float)((float)nbrOfReachedStudents / (float)nbrOfStudents);

        return percentage;
    }
}

    
