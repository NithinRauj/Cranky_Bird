using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

public GameManager instance;
public BirdControl bird;
public Text scoreText;
public Text gameOverText;
public static bool hasDied=false;
private int score=0;


//To make sure only one instance of GameManager is present at once
// void Awake()
// {
//     if(instance==null)
//     {
//         instance=this;
//     }
//     else if(instance!=null && instance!=this)
//     {
//         Destroy(this.gameObject);
//     }
// }

void Start()
{
    scoreText.text=score.ToString();
}
void Update()
{
    if(hasDied)
    {
        GameOverText();
    }
}

void UpdateScore()
{
    score++;
    scoreText.text=score.ToString();
}
void GameOverText()
{
    gameOverText.text+=score.ToString();
    gameOverText.gameObject.SetActive(true);
    hasDied=false;
}
}
