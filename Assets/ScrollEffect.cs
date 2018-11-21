using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEffect : MonoBehaviour {

private Vector2 startPos;
private float scrollSpeed=-1f;

void Start()
{
    startPos=transform.position;
}

void Update()
{
   //loos the first argument within 0 to second argument by modulo division
   float newPos=Mathf.Repeat(Time.time*scrollSpeed,8);  
   //the newPos is multiplied to x axis for forard movement
   transform.position=startPos+Vector2.right*newPos;   
  // Debug.Log(transform.position);
}
	
}
