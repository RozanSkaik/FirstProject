using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part3
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
        public static string RepeatString(this string repeatedString, int repeatTime)
        {
            string result = "";
            for (int i = 0; i < repeatTime; i++)
            {
                result += repeatedString;
            }
            return result;

        }
    }

}