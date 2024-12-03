using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;

        public Position(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public void PrintPosition()
        {
            Debug.Log("Position => X : " + X + ", Y: " + Y + ", Z: " + Z);
        }
    }
}
