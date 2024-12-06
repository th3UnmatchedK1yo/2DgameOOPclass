using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] private int requiredFruits = 100; // The number of fruits required to finish the level

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Check if the player has collected enough fruits
            if (GameController.instance.progressAmount >= requiredFruits)
            {
                // Level is complete, move to the next level
                Debug.Log("Level complete, moving to next scene!");

                // Disable the collider to prevent re-triggering the finish point
                GetComponent<Collider2D>().enabled = false;

                // Move to the next level
                SceneController.instance.NextLevel();
            }
            else
            {
                // Player hasn't collected enough fruits
                Debug.Log("Collect more fruits to complete the level!");
            }
        }
    }
}
