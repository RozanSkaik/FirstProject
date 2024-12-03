using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public Character(string characterName, int characterHealth, Position characterPosition)
        {
            this.name = characterName;
            this.Health = characterHealth;
            this.position = characterPosition;
        }

        //Default Constructor Chaining
        public Character() : this("No name", 100, new Position(0, 0, 0))
        {
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("* The Character Name is: " + name);
            Debug.Log("* The Character Health is: " + Health);
            Debug.Log("* The Character Positions are: ");
            position.PrintPosition();
            Debug.Log("-------------------------------------");
        }

        public void Attack(int damage, Character target)
        {
            this.Attack(damage, target, "UnKnown attack");  // DRY don't repeat 
        }
        public void Attack(int damage, Character target, string attackType) //attackType for example shooting or kicking
        {
            target.Health -= damage;
            Debug.Log("The Enemy " + target.name + " is damaged about " + damage + "  by attack Type: " + attackType);
            Debug.Log("Current Health = " + target.health);
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
}