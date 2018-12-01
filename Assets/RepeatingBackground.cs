using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

public float backgroundWidth;
private float xstartPosition;

void Start()
{
    xstartPosition=transform.position.x;
}

void Update()
{
    if(Mathf.Abs(transform.position.x)>=backgroundWidth)
    {
        transform.position=new Vector3(xstartPosition,0f,0f);
    }
}
}
