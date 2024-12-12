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
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}


