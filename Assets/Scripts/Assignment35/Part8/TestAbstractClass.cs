using System.Collections;
using System.Collections.Generic;
using Assignment35.Part8;
using UnityEngine;

namespace Assignment35.Part8
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            AbstractBaseClass abstractBaseClass = new DerivedClassExample();

            abstractBaseClass.PerformAction();

            abstractBaseClass.PrintInfo();
        }
    }
}