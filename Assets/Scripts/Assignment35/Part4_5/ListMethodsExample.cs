using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assignment35.Part4_5
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbersList = new List<int>() { 3, 1, 4, 1, 5, 9 };
        List<int> numbersList2 = new List<int>() { 3, 1, 4, 1, 5, 9, 2, 6 };

        void Start()
        {
            //Sorting list descending
            numbersList.Sort((x,y) => y.CompareTo(x));

            Debug.Log($"Descending sorting list: {string.Join(" , ", numbersList)}");

            //Filtering list use FindAll
            List<int> filteredNumbers = numbersList2.FindAll((num) => num % 2 == 0);

            Debug.Log($"Filtering list to even number: {string.Join(" , ", filteredNumbers)}");

        }

    }
}