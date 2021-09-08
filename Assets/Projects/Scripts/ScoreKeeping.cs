using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeping : MonoBehaviour
{
   
    public static int playerScore = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball")){
            playerScore += 1;
            Debug.Log("Score : " + playerScore);
            
        }
        
    }
}
