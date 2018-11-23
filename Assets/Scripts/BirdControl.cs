using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour {

private Rigidbody2D rb;
private Animator anim;
public float vertVelocity=2f;
void Start()
{
  rb=GetComponent<Rigidbody2D>();
  anim=GetComponent<Animator>();
}
void Update()
{
    //For playtesting with mouse 
    if(Input.GetMouseButtonDown(0))                 
    {
      rb.velocity=new Vector2(rb.velocity.x,vertVelocity);
      anim.SetBool("isFlapping",true);
      Debug.Log("Flap");
    }
    else{
      anim.SetBool("isFlapping",false);
    }

    if(Input.touchCount>0)
    {
      rb.velocity=new Vector2(rb.velocity.x,vertVelocity);
    }
  
  
}
	
}
