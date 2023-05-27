using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneToLoad = "ItsjustaGame";
    // Add any necessary variables or references here

    // Method to load a specific level by name
    public void LoadGame ()
    {
        SceneManager.LoadScene(sceneToLoad);

    }

    // Method to reload the current level
    public void ReloadLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Method to quit the game
    public void QuitGame ()
    {
        Application.Quit();
    }
}


