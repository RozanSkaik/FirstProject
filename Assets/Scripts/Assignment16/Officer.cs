using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16
{
    public class Officer : Character
    {
        public Officer(string characterName, int characterHealth, Position characterPosition) : base(characterName, characterHealth, characterPosition) 
        { 
        }
        public Officer() : base("No name", 100, new Position(0, 0, 0)) { }
        public override void DisplayInfo()
        {
            Debug.Log("*** Officer ***");
            base.DisplayInfo();
        }
    }
}
