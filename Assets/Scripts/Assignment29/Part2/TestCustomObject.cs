using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part2
{
    public class TestCustomObject : MonoBehaviour
    {
        CustomObject customObject;
        CustomObject customObject2;

        void Start()
        {
            customObject = new CustomObject(123, "Rozan");
            print(customObject);

            customObject2 = new CustomObject(124, "Lemara");
            print(customObject2);
            print($"Custom Object 1 == Custom Object 2 ? {customObject == customObject2}");

        }
    }
}