using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();
        
        player1.InitializePlayer("Rozan", 50);
        player2.InitializePlayer("Ahmed", 70);

        //Add heal to Player 1
        player1.Heal(20);
        player1.Heal(true);        
        
        //Add heal to Player 2
        player2.Heal(10);
        player2.Heal(true);

        //Total number of Players
        Player.ShowPlayerCount();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
