using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
        
    }

    public void Character()
    {
        SceneManager.LoadScene("Character_Select");

    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
  
}
