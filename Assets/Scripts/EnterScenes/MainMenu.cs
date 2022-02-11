using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    Player player;
    public void Awake(){
        player=Player.Instance;
    }
    public void PlayGame()
    {
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
