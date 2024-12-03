using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{

    public class CharacterTest : MonoBehaviour
    {
        Soldier solider;
        Officer officer;
        Character[] characters;
        Position positionSolider;
        Position positionOfficer;

        void Start()
        {
            positionSolider = new Position(1.4f, 2.2f, 3.5f);
            positionOfficer = new Position(3.5f, 5.9f, 2.5f);

            solider = new Soldier(); //non parameterized constructor
            officer = new Officer("The First Officer", 80, positionOfficer); //parameterized constructor

            characters = new Character[] { solider, officer }; // use polymorphism to store them in array

            for (int i = 0; i < characters.Length; i++)
            {
                Character character = characters[i];
                character.DisplayInfo();
            }
            officer.Attack(10, officer, "Shooting"); // to test overloading methods

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}