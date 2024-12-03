using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18.Part1
{
    public class GameUtils
    {
        public static string DescribeItem<T>(T something){
            return "This item is " + something;
        }
    }
}