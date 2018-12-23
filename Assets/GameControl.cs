using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour {

public Text scoreText;
public Text gameOverText;
public GameObject replayButton;
public int score=0;
public static GameControl instance;

#region singleton
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
#endregion
    
void Start()
{
  scoreText.text=score.ToString();  
}

// void Update()
// {
//   if(BirdController.isDead && (Input.touchCount>1 || Input.GetMouseButtonDown(0)))
//   {
//     BirdController.isDead=false;
//     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//   }

// }

//when replay button is pressed the below method will be executed
public void ResetGame()
{
  if(BirdController.isDead)
  {
    BirdController.isDead=false;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

}

public void DisplayFinalScore()
{
  replayButton.SetActive(true);
  scoreText.gameObject.SetActive(false);
  gameOverText.gameObject.SetActive(true);
  gameOverText.text+=score.ToString();
}
public void UpdateScore()
{
  score++;
  scoreText.text=score.ToString();
}
}
