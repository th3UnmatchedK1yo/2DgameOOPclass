using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGamr()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void CharacterSelector()
    {
        SceneManager.LoadScene("Character");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        // Stop play mode in the Unity Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Quit the application in a built game
        Application.Quit();
#endif
    }

}


