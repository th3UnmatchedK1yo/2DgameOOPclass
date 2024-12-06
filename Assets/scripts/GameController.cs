using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;  // Add this line to create a static reference to this class
    public int progressAmount;
    public Slider progressSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;  // Set the static reference to this instance
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        progressAmount = 0;
        progressSlider.value = 0;
        Fruits.OnFruitCollect += IncreaseProgressAmount;
    }

    public int GetProgressAmount()
    {
        return progressAmount;
    }

    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount;

        if (progressAmount >= 100)
        {
            // Level complete (optional check)
            Debug.Log("Level Complete");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic if needed
    }
}
