using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class NumberGenerator : MonoBehaviour
{
    // Start is called before the firstframe update
    void Start()
    {
        while(true){
           int randomNumber  = Random.Range(1,21); //from 1 to 20

           if (randomNumber == 5) {
             Debug.Log("Yes, Continue :)"); //don't print  the randomNumber and continue
             continue;
           }

           Debug.Log("The Number: " + randomNumber);

           if (randomNumber == 15){
             Debug.Log("No, Stop"); // print 15 and break the loop
             break;
           } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
