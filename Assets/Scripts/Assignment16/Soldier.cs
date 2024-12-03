using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Soldier : Character
    {
        public Soldier(string characterName, int characterHealth, Position characterPosition) : base(characterName, characterHealth, characterPosition)
        {
        }
        public Soldier() : base("No name", 100, new Position(0, 0, 0)) { }

        public override void DisplayInfo()
        {
            Debug.Log("*** Soldier ***");
            base.DisplayInfo();
        }
    }
}