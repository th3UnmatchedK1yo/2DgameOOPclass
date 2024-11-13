using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour, Item
{
    public void Collect()
    {
        Destroy(gameObject);
    }

    
}
