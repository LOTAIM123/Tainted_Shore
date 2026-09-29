using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    [SerializeField] private Gradient gradientNightToSunrise;
    [SerializeField] private Gradient gradientSunriseToDay;
    [SerializeField] private Gradient gradientDayToSunset;
    [SerializeField] private Gradient gradientSunsetToNight;

    [SerializeField] private Light globalLight;

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

    private void Awake()
    {
        Time.timeScale = 4f;
    }

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
            StartCoroutine(LerpLight(gradientNightToSunrise, 10f));
        }
        else if (value == 8)
        {
            StartCoroutine(LerpLight(gradientSunriseToDay, 10f));
        }
        else if (value == 18)
        {
            StartCoroutine(LerpLight(gradientDayToSunset, 10f));
        }
        else if (value == 22)
        {
            StartCoroutine(LerpLight(gradientSunsetToNight, 10f));
        }
    }

    private IEnumerator LerpLight(Gradient lightGradient, float time)
    {
        for (float i =0; i < time; i += Time.deltaTime)
        {
            globalLight.color = lightGradient.Evaluate(i / time);
            RenderSettings.skybox.SetFloat("_Blend", i / time);
            yield return null;
        }
    }

}
