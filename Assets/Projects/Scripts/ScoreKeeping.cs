using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeping : MonoBehaviour
{
    public TextMeshProUGUI currentScore;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.text = (currentScore.ToString());
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball")){
            score += 1;
            Debug.Log("Score : " + score);
            
        }
        
    }
}
