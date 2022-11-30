using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    PlayerController playerController;
    public Slider slider;
    int healthBarVal = 0;
    void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        healthBarVal = playerController.health;
    }
    void Update()
    {
        healthBarVal = playerController.health;
        slider.value = healthBarVal;
    }
    
    
}
