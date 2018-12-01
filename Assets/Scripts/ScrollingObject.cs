using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

public float scrollSpeed;


void Update()
{
    if(!BirdController.isDead)
    {
        transform.Translate(-scrollSpeed*Time.deltaTime,0f,0f);
    }
    else
    {
        return;
    }
}	
}
