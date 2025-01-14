using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35.Part1
{
    public class BoxingUnboxing : MonoBehaviour
    {
        int health = 100;

        void Start()
        {
            //Boxing::
            object boxHealth = health;

            //Unboxing::
            int unboxHealth = (int)boxHealth;

            //Modify it::
            unboxHealth = 20;

            Debug.Log($"Before Boxing, health = {health}");
            Debug.Log($"After Boxing, health = {boxHealth}");
            Debug.Log($"After Unboxing, health = {unboxHealth}");
        }
    }
}