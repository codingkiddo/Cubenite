using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreNumber = 0 ;
    public int x = 0;
    public Text scoreText; 
    
    void Update()
    {
        x++;
        if (x % 10 == 0) {
            scoreNumber++;  
            scoreText.text = scoreNumber.ToString();
        }
       
    }
}
