using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource source;

    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    // Method to play sound
    public void PlaySound(AudioClip _sound)
    {
        // Play the sound no matter what, without checking if it's the same as the previous one
        source.PlayOneShot(_sound);
    }

    // Method to stop any currently playing sound
    public void StopSound()
    {
        // Stop the audio source from playing any sound
        source.Stop();
    }
}
