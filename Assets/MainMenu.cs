using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void PlayGame(){
        SceneManager.LoadScene(2);
    }
   

   public void QuitGame(){
    Application.Quit();
   }

   public void Settings(){
    SceneManager.LoadScene(3);
   }

   public void RetryLevel(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevelScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Back(){
        SceneManager.LoadScene(1);
    }
}
