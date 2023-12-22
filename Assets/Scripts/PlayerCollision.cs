using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Rigidbody rb;
    

    


    //called whenever our object collides with something
    void OnCollisionEnter(Collision collisionInfo){
       
     
       
       //if we collide into an object with the name 'obstacle"
       if(collisionInfo.collider.tag == "Obstacle"){
            
            FindObjectOfType<PlayerMovement>().slowDown();  //slows down player speed 
            
            FindObjectOfType<PlayerMovement>().Invoke("stopMove", 1f);  //stops player

            FindObjectOfType<GameManager>().Invoke("RetryScreen", 1.5f);  //displays retry screen 1.5s after crashing
          
       }

          
       
          //if the player reaches finish line
       if(collisionInfo.collider.name == "Finish Line"){
            FindObjectOfType<PlayerMovement>().slowDown();  //disables player movement 
            
            FindObjectOfType<PlayerMovement>().Invoke("stopMove", 1f);
             

          FindObjectOfType<GameManager>().Invoke("NextLevelScreen", 1f);

       }
    }



}
