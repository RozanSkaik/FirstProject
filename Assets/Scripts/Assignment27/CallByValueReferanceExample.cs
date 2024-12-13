using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallByValueReferanceExample : MonoBehaviour
    {
        void Start()
        {
            int num1 = 5;
            int num2 = 15;

            Debug.Log("The number 1 before Changed: " + num1);
            ChangeNumberByValue(num1);
            Debug.Log("The number 1 when Call by Value: " + num1);

            Debug.Log("The number 2 before Changed: " + num2);
            ChangeNumberByReferance(ref num2);
            Debug.Log("The number 2 when Call by Reference: " + num2);

            int num3; //uninitialized variables
            ChangeNumberUsingOut(out num3);
            Debug.Log("The number 3 when Using the out: " + num3);
        }
        public void ChangeNumberByValue(int newNum)
        {
            newNum = 10;
        }
        public void ChangeNumberByReferance(ref int newNum)
        {
            newNum = 10;
        }
        public void ChangeNumberUsingOut(out int newNum)
        {
            newNum = 20;
        }
    }
}