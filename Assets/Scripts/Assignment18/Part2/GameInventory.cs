using System.Collections;
using System.Collections.Generic;
using Assignment18.Part2;
using UnityEngine;

namespace Assignment18.Part2
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory potionsInventory = new Inventory();
            potionsInventory.AddItem("Healing Potion");
            potionsInventory.AddItem("Strength Potion");
            
            Inventory elixirsInventory = new Inventory();
            elixirsInventory.AddItem("Elixir");
            elixirsInventory.AddItem("Dark Elixir");

            Inventory combinedInventory = potionsInventory + elixirsInventory; //Mix it !!

            combinedInventory.ShowItems();
        }
    }
}