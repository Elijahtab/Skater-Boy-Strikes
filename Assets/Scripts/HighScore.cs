using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    PlayerController playerController;
    [SerializeField] Text highScore;
    int scoreHS;
    
    void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    void Update()
    {
        
        if(scoreHS < playerController.score)
        {
            scoreHS = playerController.score;
            PlayerPrefs.SetInt("HighScore", scoreHS);
        }
        
        
    }
}
