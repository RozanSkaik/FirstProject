using System.Collections;
using System.Collections.Generic;
using Assignment29.Part3;
using UnityEngine;

namespace Assignment29.Part3
{

    public class TestUtilities : MonoBehaviour
    {
        void Start()
        {
            Debug.Log($"The Total Number: {Utilities.Add(2, 4, 5, 3, 6, 8)}");
            Debug.Log($"The Repeated Text: {"Rozan ".RepeatString(5)}");
        }
    }
}