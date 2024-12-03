using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character // Base Class
{
    //Fields:
    private string name = "";
    private int health = 100;

    //Constuctors:
    public Character(string characterName, int characterHealth)
    {
        this.Name = characterName;
        this.Health = characterHealth;
    }
    // public Character(): this("",100){}

    //Properties:
    public string Name
    {
        get { return name; }
        set
        {
            //Check, to control and protect the information
            if (value == "")
            {
                name = "UnKnown"; 
            }
            else name = value;
        }
    }
    public int Health
    {
        get { return health; }
        set
        {
            //Checks, to control and protect the information
            if (value > 100)
            {
                Debug.Log("⚠️ Sorry, " + value + " isn't correct, The Maximum of your Health 100!");
                health = 100;
            }
            else if (value < 0)
            {
                Debug.Log("⚠️ Sorry, " + value + " isn't correct, The Minimum of your Health 0!");
                health = 0;
            }
            else health = value;
        }
    }
}
