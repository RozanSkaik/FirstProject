using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18.Part1
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>();

            gameContainer.SetItem("Healing Potion");
            Debug.Log("Stored item: " + gameContainer.GetItem());

            string describedItem = GameUtils.DescribeItem<string>(gameContainer.GetItem());
            Debug.Log(describedItem);

        }
    }
}