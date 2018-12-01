using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {

public Text scoreText;
public Text gameOverText;
public int score=0;

public static GameControl instance;

/* implemented singleton pattern to make sure only one instance of GameControl 
is present at a time*/
void Awake()
{
 if(instance==null)
 {
   instance=this;
 }
 if(instance!=null && instance!=this )
 {
   Destroy(this.gameObject);
 }
}
    
void Start()
{
  scoreText.text=score.ToString();  
}

public void DisplayFinalScore()
{
  gameOverText.gameObject.SetActive(true);
  gameOverText.text+=scoreText.text;
}
public void UpdateScore()
{
  score++;
  scoreText.text=score.ToString();
}
}
