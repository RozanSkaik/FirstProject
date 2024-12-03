using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName = "";
    public int health = 0;

    static public int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth){
        playerName = name;
        health = initialHealth;
        //increase player count
        playerCount ++;
    }
    public void Heal(int amount){
        health += amount;
        Debug.Log(playerName + "'s icrease the health to " + amount + ", so The Total Health = " + health);
    }
    public void Heal(bool fullRestore){
        if (fullRestore == true){
            health = 100;
            Debug.Log(playerName + "'s fully restored health to " + health);
        }
    }
    public static void ShowPlayerCount(){
         Debug.Log("Total number of Players: " + playerCount);
    }
}
