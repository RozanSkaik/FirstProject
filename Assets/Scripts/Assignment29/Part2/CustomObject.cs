using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part2
{
    public class CustomObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomObject(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }
        //Comment it out
        // public override bool Equals(object obj)
        // {
        //     CustomObject customObject = obj as CustomObject;
        //     if (customObject != null)
        //     {
        //         return customObject.ID == this.ID && customObject.Name == this.Name;
        //     }
        //     return false;
        // }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj2.Equals(null))
            {
                if (obj1.ID.Equals(obj2.ID) && obj1.Name.Equals(obj2.Name)) return true;
            }
            return false;
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj2.Equals(null))
            {
                if (!obj1.ID.Equals(obj2.ID) && obj1.Name.Equals(obj2.Name)) return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}