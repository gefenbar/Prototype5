using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    Player player;

    public void PlayGame()
    {
                player=Player.Instance;
        SceneManager.LoadScene("Main");
    }

 public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
     public void Rules()
    {
        SceneManager.LoadScene("GameRules");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
