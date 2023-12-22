using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

public Rigidbody rb;
public float forwardForce = 2000f;
public float sideForce = 500f;
public bool startedGame = false;
public TextMeshProUGUI startText;

    // Start is called before the first frame update
    void Start() {
        
        
        
    }

    // Update is called once per frame
    void FixedUpdate() {  


        

        if(Input.GetKey("f")){
            
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            startedGame = true;
    }
        //made it so that players cant move side to side before pressing f and starting game

        if(startedGame == true){
                    rb.AddForce(0, 0, forwardForce * Time.deltaTime);   //Time helps even out the force speed, since diff computers have diff framerates, the speed would be different since the updates are called based on framerate. Time stops this.

        
        
        
        

        if(Input.GetKey("d")){
            rb.AddForce(sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange); //forcemode.velocity change lets the cube move side to side without slowly building up speed, making it easier to dodge
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.x <-8.6f || rb.position.x >8.6f || rb.position.y < -15f){
            
            slowDown();  //disables player movement 
            
            stopMove();

            FindObjectOfType<GameManager>().Invoke("RetryScreen", 1f);
          
       }

        
        }   
   


    }

    public void slowDown(){
       
         
            rb.drag = 10;
            
    }

    public void stopMove(){

        rb.drag = 500000;
    }


    
}
