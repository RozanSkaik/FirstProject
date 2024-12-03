using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character //Child Class 2
{
    public Enemy(string characterName, int characterHealth) : base(characterName, characterHealth) { }

    public void Attack(int damage)
    {
        this.Health -= damage;
    }

    public void PrintEnemyNameAndHealth()
    {
        Debug.Log("The Enemy Name: " + this.Name + ", The Health = " + this.Health);

    }
}
