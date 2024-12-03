using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    Player2 player = new Player2("Rozan", 100);
    Enemy enemy = new Enemy("Monster", 50);

    void Start()
    {
        player.PrintPlayerNameAndHealth();
        Debug.Log("****************************");
        enemy.PrintEnemyNameAndHealth();
        Debug.Log("****************************");

        player.Heal(30);
        Debug.Log("The Player " + player.Name + " After Heals, Health = " + player.Health);
        Debug.Log("****************************");

        enemy.Attack(60);
        Debug.Log("The Enemy " + enemy.Name + " After Attack, Health = " + enemy.Health);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
