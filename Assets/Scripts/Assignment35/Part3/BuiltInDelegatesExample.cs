using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35.Part3
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action<string> logMessage = (string logMessageText) => Debug.Log(logMessageText);

        Func<int, int> squareNumber = (int number) => (int)Mathf.Pow(number, 2);

        Predicate<int> isEven = (int number) => number % 2 == 0;

        void Start()
        {
            //Use Action Delegate
            logMessage("Hello from Action delegate!");

            //Use Func Delegate
            Debug.Log($"Square: {squareNumber(5)}");

            //Use Predicate Delegate
            Debug.Log($"Is 4 even? {isEven(4)}");

        }
    }
}