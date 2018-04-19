using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    public School[] schools = new School[2];
    public ushort totalStudentsReached;
    public Text counterText;

    void Update()
    {
        totalStudentsReached = 0;

        for (int i = 0; i < schools.Length; i++)
        {
            totalStudentsReached += schools[i].nbrOfReachedStudents;
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        counterText.text = totalStudentsReached.ToString();
    }
}
