using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour {

private Rigidbody2D rb;
public float flyPower=2f;
void Start()
{
  rb=GetComponent<Rigidbody2D>();
}
void Update()
{
    // if(Input.GetMouseButtonDown(0))                 //For testing with mouse controls
    // {
    //   rb.velocity=new Vector2(rb.velocity.x,flyPower);
    // }

    if(Input.touchCount>0)
    {
      rb.velocity=new Vector2(rb.velocity.x,flyPower);
    }
  
}
	
}
