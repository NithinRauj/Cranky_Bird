using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {

//public GameControl instance;
public Text scoreText;
public Text gameOverText;
public int score=0;
    
void Start()
{
  scoreText.text=score.ToString();  
}
public void UpdateScore()
{
  score++;
  scoreText.text=score.ToString();
}
}
