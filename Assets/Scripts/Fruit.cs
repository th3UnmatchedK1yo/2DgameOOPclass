using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour, Item
{

    public static event Action<int> OnFruitCollect;
    public int worth = 5;

    public void Collect()
    
    
    {
        Debug.Log("Fruit collected! Worth: " + worth);
        OnFruitCollect.Invoke(worth);
        Destroy(gameObject);
    }

    
}
