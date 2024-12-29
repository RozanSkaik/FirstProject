using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29.Part4
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            //Upcasting::
            Cat catMeow = new Cat();
            Animal animal = catMeow;

            animal.MakeSound();
            animal.Move();

            //Downcasting::
            Cat catMeow2 = animal as Cat; //Downcast the animal reference
            catMeow2.MakeSound();
            catMeow2.Move();

            //Type Checking::
            List<ICanFight> canFights = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (ICanFight canFight in canFights)
            {
                canFight.Attack();
            }

            foreach (ICanFight canFight in canFights)
            {
                if (canFight is Cat)
                    Debug.Log("The object is a Cat.");
                else if (canFight is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
            //Note: we can use one foreach but with different ordering in Expected Output ^_^
        }

    }
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }
        public void Move()
        {
            Debug.Log("Animal moves.");
        }
    }
    public class Cat : Animal, ICanFight
    {

        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        public new void Move() //We don't need to override it so Make a new method
        {
            Debug.Log("Cat runs quickly.");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
    public interface ICanFight
    {
        public void Attack();
    }
}