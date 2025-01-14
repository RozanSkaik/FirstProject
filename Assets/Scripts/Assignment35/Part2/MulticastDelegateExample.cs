using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35.Part2
{
    public delegate void MathOperation(int number);

    public class MulticastDelegateExample : MonoBehaviour
    {
        MathOperation operation;

        void OnEnable()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
        }
        void Start()
        {
            operation(5);
            // operation?.Invoke(5);
        }
        void OnDisable()
        {
            operation -= DoubleNumber;
            operation -= SquareNumber;
            operation -= CubeNumber;
        }

        void DoubleNumber(int number)
        {
            Debug.Log($"Double of Number: {number} = { number * 2 }");
        }
        void SquareNumber(int number)
        {
            Debug.Log($"Square of Number: {number} = { Mathf.Pow(number, 2) }");
        }
        void CubeNumber(int number)
        {
            Debug.Log($"Cube of Number: {number} = { Mathf.Pow(number, 3) }");
        }
    }

}