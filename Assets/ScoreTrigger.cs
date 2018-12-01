using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

public GameControl gameControl;
 void OnTriggerEnter2D(Collider2D collider)
 {
   if(collider.GetComponent<BirdController>())
   {gameControl.UpdateScore();}
 }
}
