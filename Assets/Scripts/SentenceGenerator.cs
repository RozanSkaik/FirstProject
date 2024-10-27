using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SentenceGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        String[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int count = 0;
        String funnySentence = "";
        while(count < 7){
            int index = Random.Range(0, words.Length);
            funnySentence += words[index] + " ";
            count ++;
        }
        Debug.Log("The Funny Sentence: " + funnySentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
