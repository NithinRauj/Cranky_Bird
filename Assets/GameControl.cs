using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {

	public Text scoreText;
    public Text gameOverText;
    public int score=0;
    
    void Start()
    {
        
    }
    void UpdateScore()
    {
      score++;
    }
}
