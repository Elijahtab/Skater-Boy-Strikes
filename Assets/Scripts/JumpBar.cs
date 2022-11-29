using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpBar : MonoBehaviour
{
    PlayerController playerController;
    public Slider slider;
    int jumpBarVal = 0;
    void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        jumpBarVal = playerController.jumpMeter;
    }
    void Update()
    {
        jumpBarVal = playerController.jumpMeter;
        slider.value = jumpBarVal;
    }
    
    
}
