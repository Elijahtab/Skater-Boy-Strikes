using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{   
    [SerializeField] private List<GameObject> HealthBarStates;
    PlayerController playerController;
    int healthCheck = 0;
    private GameObject MyEnemies;

    void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        healthCheck = playerController.health;
        GameObject.Instantiate(HealthBarStates[(playerController.health)]);
    }

    void Update()
    {
        if (playerController.health < healthCheck)
        {
            MyEnemies = GameObject.FindGameObjectWithTag("Health");
            DestroyObject(MyEnemies);
            GameObject.Instantiate(HealthBarStates[(playerController.health)]);
            healthCheck = playerController.health;
            Debug.Log(playerController.health);
            
        }
        
        
    }
    
}
