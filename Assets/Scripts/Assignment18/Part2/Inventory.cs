using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18.Part2
{
    public class Inventory
    {
        private List<string> listItems = new List<string>();

        public void AddItem(string item)
        {
            this.listItems.Add(item);
        }
        public void ShowItems()
        {
            Debug.Log("All Inventory Names: ");
            foreach (string item in listItems)
            {
                Debug.Log(item);
            }
        }
        public static Inventory operator +(Inventory obj1, Inventory obj2)
        {
            Inventory combinedInventories = new Inventory(); //To Create Combined List

            combinedInventories.listItems.AddRange(obj1.listItems); //Add List1 to Combined List
            combinedInventories.listItems.AddRange(obj2.listItems); //Add List2 to Combined List

            return combinedInventories;
        }

    }
}