using UnityEngine;
using UnityEngine.SceneManagement;  //used when we want to reuse a scene/restart a scene

public class GameManager : MonoBehaviour
{

public bool gameHasEnded = false; //game starts with this equal to false
public float delay = 2;

public GameObject retryLevelUI;
public GameObject nextLevelUI;


    public void EndGame(){


        if(gameHasEnded == false){
            gameHasEnded = true;         //when EndGame is called (when cube falls below y<-1 or crashes), the bool is set to true, and this if statement only goes through once
            Debug.Log("GAME OVER");
            
            
        }

    }

    public void Restart(){

        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);    //loads the active scene, so we don't have to put a specific scene name in there
 
    }

    public void RetryScreen(){
            retryLevelUI.SetActive(true);
    }

    public void NextLevelScreen(){
        nextLevelUI.SetActive(true);
    }

    
    
}
