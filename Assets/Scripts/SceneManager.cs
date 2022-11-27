using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public string mainMenu = "Main Menu";
    public string levelSelect = "Level Select";
    public string credits = "Credits";
    public string howToPlay = "How To Play";

    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(mainMenu);
        Debug.Log("This loads the Main Menu.");
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("This loads the next scene in the index.");
    }
    public void GoToLevelSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelSelect);
        Debug.Log("This loads level select.");
    }
    public void GoToCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(credits);
        Debug.Log("This loads the credits.");
    }
    public void GoToHowToPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(howToPlay);
        Debug.Log("This loads the how to play scene.");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("This quits.");
    }
}
