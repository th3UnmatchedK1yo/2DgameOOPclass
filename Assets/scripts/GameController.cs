using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    int progressAmount;
    public Slider progressSlider; 
    // Start is called before the first frame update
    void Start()
    {
        progressAmount = 0;
        progressSlider.value = 0;
        Fruits.OnFruitCollect += IncreaseProgressAmount;
    }
    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount;

        if (progressAmount >= 100)
        {
            //level complete
            Debug.Log("Level Complete");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
