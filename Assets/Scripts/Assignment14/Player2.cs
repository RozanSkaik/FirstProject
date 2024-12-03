using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character //Child Class 1
{
    public Player2(string characterName, int characterHealth) : base(characterName, characterHealth) { }

    public void Heal(int amount)
    {
        this.Health += amount;
    }
    public void PrintPlayerNameAndHealth()
    {
        Debug.Log("The Player Name: " + this.Name + ", The Health = " + this.Health);
    }
}
