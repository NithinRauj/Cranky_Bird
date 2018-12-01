using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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

void Update()
{
  if(BirdController.isDead && (Input.touchCount>1 || Input.GetMouseButtonDown(0)))
  {
    BirdController.isDead=false;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

}

public void DisplayFinalScore()
{
  scoreText.gameObject.SetActive(false);
  gameOverText.gameObject.SetActive(true);
  gameOverText.text+=score.ToString();
  gameOverText.text+="\nTouch to play again";
}
public void UpdateScore()
{
  score++;
  scoreText.text=score.ToString();
}
}
