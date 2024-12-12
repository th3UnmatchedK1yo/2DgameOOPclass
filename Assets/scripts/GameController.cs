using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public int progressAmount;
    public Slider progressSlider;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        progressAmount = 0;
        progressSlider.value = 0;
        Fruits.OnFruitCollect += IncreaseProgressAmount;
        Health.OnPlayedDied += GameOverScreen;
        gameOverScreen.SetActive(false);
    }

    void GameOverScreen()
    {
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }
        else
        {
            Debug.LogWarning("GameOverScreen is null!");
        }
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
            Debug.Log("Level Complete");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic if needed
    }

    public void ResetGame()
    {
        StartCoroutine(ResetReferences()); // Start reset process
    }

    private IEnumerator ResetReferences()
    {
        // Wait for the next frame to ensure the scene is properly loaded
        yield return null;

        // Reload the scene (reset the game)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Find and reset gameOverScreen reference if needed
        gameOverScreen = GameObject.Find("GameOverScreen"); // Ensure correct name of the GameObject

        if (gameOverScreen == null)
        {
            Debug.LogWarning("GameOverScreen not found after scene reload");
        }

        // Find Health component of the player and reset it
        Health playerHealth = FindObjectOfType<Health>();
        if (playerHealth != null)
        {
            playerHealth.ResetHealth(); // Reset the health of the player
        }
        else
        {
            Debug.LogWarning("Health component not found!");
        }
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Home");
    }
}






/*


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;  // Add this line to create a static reference to this class
    public int progressAmount;
    public Slider progressSlider;



    public GameObject gameOverScreen;

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

        Health.OnPlayedDied += GameOverScreen;
        gameOverScreen.SetActive(false);
    }



    void GameOverScreen()
    {
        gameOverScreen.SetActive(true);

    }



    public void ResetGame()
    {

        SceneManager.LoadScene("Level 1");

        gameOverScreen.SetActive(false);

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


*/