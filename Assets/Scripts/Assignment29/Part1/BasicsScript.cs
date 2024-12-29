using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part1
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var numberInt = 9;
            var oddResult = $"The number {numberInt} is odd.";
            var evenResult = $"The number {numberInt} is even.";

            bool isOdd = numberInt % 2 == 1;
            Debug.Log(isOdd ? oddResult : evenResult);

            Debug.Log($"The Current Date: {DateTime.Now.Date.ToShortDateString()}");
            Debug.Log($"The Current Time: {DateTime.Now.TimeOfDay}");
            Debug.Log($"The Current Day: {DateTime.Now.DayOfWeek}");
        }


    }
}