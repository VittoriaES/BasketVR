using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScoreScript : MonoBehaviour
{
     public TextMeshProUGUI scoreDisplay;
     private static int score;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = ScoreKeeping.playerScore;
        scoreDisplay.text = "Score : " + score.ToString();
    }
}
