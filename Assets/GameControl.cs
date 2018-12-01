using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {

public Text scoreText;
public Text gameOverText;
public int score=0;

private int gameControls=0;

//implemented singleton pattern to make sure only one instance of GameControl is present at a time
void Awake()
{
  gameControls=GameObject.FindObjectsOfType<GameControl>().Length;
  if(gameControls>1)
  {
    Destroy(gameObject);
  }
  else
  {
      DontDestroyOnLoad(gameObject);
  }
}
    
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
