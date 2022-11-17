using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameStateManager : MonoBehaviour
{
      
    public static float EnemyMoveSpeed { get; private set; } //A read only global property that makes it easy for us to change the move speed of the pillars.

    [SerializeField]
    private GameObject GameOverScreen; //A reference to the GameObject that is the GameOver UI Screen
    [SerializeField]
    private float enemyMovespeed; //An adjustable float for the enemy move speed


    private static GameStateManager _instance; //Setting the GameStateManege to a singleton
    




    // Start the game, making a singleton for the game state
    void Start()
    {
        if (_instance == null)
        {
            _instance = this;

            DontDestroyOnLoad(_instance);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }


        //Sets the move speed of the enemys in a acessable field

        EnemyMoveSpeed = enemyMovespeed;
    }


    //These two methods help up to handle the Game being over and restarting. 
    public static void GameOver()
    {
        SceneManager.LoadScene(2);

    }

    public static void Restart()
    {
        //Set the scene to the Menu scene in this case scene 0
        SceneManager.LoadScene(0);
    }

}
