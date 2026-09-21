using System;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    private int minutes;
    public int Minutes
    { get { return Minutes; } set { Minutes = value; OnMinutesChange(value); } }

    private int hours;
    public int Hours
    { get { return Hours; } set { Hours = value; OnHoursChange(value); } }

    private int days;
    public int Days
    { get { return Days; } set { Days = value; } }

    private float TempSeconds;

    public void Update()
    {
        TempSeconds += Time.deltaTime;
        if(TempSeconds >= 1)
        {
            minutes += 1;
            TempSeconds = 0;
        }
        
    }

    private void OnMinutesChange(int value)
    {
        if (value >= 60)
        {
            Hours++;
            minutes = 0;
        }
        if (Hours >= 24)
        {
            Hours = 0;
            Days++;
        }
    }

    private void OnHoursChange(int value)
    {
        if (value == 6)
        {
        }
        else if (value == 8)
        {
        }
        else if (value == 18)
        {
        }
        else if (value == 22)
        {
        }
    }

}
