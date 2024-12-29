using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part7
{
    public class RecursionScript : MonoBehaviour
    {
        int n1 = 10;
        int n2 = 30;
        void Start()
        {
            print($"Recursive Fibonacci of {n1} : {FibonacciRecursive(n1)}");
            print($"Recursive Fibonacci of {n2} : {FibonacciRecursive(n2)}");

            print($"Iterative Fibonacci of {n1} : {FibonacciIterative(n1)}");
            print($"Iterative Fibonacci of {n2} : {FibonacciIterative(n2)}");
        }
        int FibonacciRecursive(int n)
        {
            // Base Condition
            if (n <= 1) return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int num1 = 0;
            int num2 = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = num1 + num2; //0 + 1 = 1 , 1 + 1 = 2, 1 + 2 = 3, 2 + 3 = 5,...
                num1 = num2; // = 1 , =1, = 2, = 3,...
                num2 = result; // = 1, = 2 , = 3, = 5,...
            }
            return result;
        }
    }
}