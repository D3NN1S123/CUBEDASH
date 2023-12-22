using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{


    public AudioClip music;
    public static Music instance;

    public void Awake(){

       if(instance==null){
        DontDestroyOnLoad(gameObject);
       }
       else{
        Destroy(gameObject);
       }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
