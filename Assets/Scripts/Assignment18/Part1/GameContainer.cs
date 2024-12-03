using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment18.Part1
{
    public class GameContainer<T>
    {
        public T item;

        public void SetItem(T item)
        {
            this.item = item;
        }
        
        public T GetItem()
        {
            return this.item;
        }
    }
}
