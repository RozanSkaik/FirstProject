using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numberTable = 5;

        Debug.Log("** The " + numberTable + "’s Multiplication Table: **");

        for(int i = 1; i <= 10; i++){
            int result = Multiply(numberTable, i);        
            Debug.Log(numberTable + " x " + i + " = " + result);
        }
        
    }

    int Multiply(int num1, int num2){
        int multiplyResult = num1 * num2;
        return multiplyResult;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
