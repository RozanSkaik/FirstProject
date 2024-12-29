using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part5
{
    public class ExceptionHandlingExample : MonoBehaviour
    {
        int playerScore = 100;
        int diviser = 0;
        void Start()
        {
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / diviser;
            }
            catch (DivideByZeroException error)
            {
                Debug.LogError($"Error: Division by zero occurred while calculating score multiplier. {error.Message}");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}