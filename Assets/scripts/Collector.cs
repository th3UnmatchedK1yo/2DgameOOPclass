using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [Header("Collect Sound")]
    [SerializeField] private AudioClip collectSound; // Reference to the collect sound
    private AudioSource audioSource; // Reference to AudioSource


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();
        if (item != null)
        {
            item.Collect();
            SoundManager.instance.PlaySound(collectSound);


        }
    }
}
