using System.Collections;
using UnityEngine;
using Beginning.CSharp;
using NPC.Bots;

public class HelloWorld : MonoBehaviour
{

    Player playerOne;
    Alien alien;

    void Start()
    {
       playerOne = new Player();
       playerOne.Name = "Barney";
       playerOne.SetScore(100);
       playerOne.Lives = 3;

        int aScore = 100;
        playerOne.SetScore(aScore);
        Debug.Log ("A score is: " + aScore);

       alien = new Alien();
       alien.SetIsAlive(false);
       alien.SetHitPoints(1);
       alien.SetPointValue(100);
    }

    void OnDisable()
    {
        Debug.Log ("Name: " + playerOne.Name + ", Score: " + playerOne.GetScore() + ", Lives: " + playerOne.Lives);
        Debug.Log ("Is Alive: " + alien.GetIsAlive() + ", Point Value: " + alien.GetPointValue());
    }
}
