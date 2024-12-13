using UnityEngine;

namespace Assignment26
{
    // Base Class
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }
   
}