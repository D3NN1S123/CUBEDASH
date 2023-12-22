using TMPro;
using UnityEngine;
  //used when we edit text and UI things

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText; 
    public TextMeshProUGUI startText;
    
    

    // Update is called once per frame
    void Update()
    {

       // scoreText.text = player.position.z.ToString("0");

        if(Input.GetKey("f")){
           startText.text = "";
        } 
  
    }


    
   
        
      
}
