using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Has Quit!");
    }
    
    public void NextLevel()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void ShowLevel(string SceneToLoad)
    {
        SceneManager.LoadScene("LevelScreen");
    }

       
    }


    

