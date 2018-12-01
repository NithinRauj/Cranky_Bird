using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {
public GameObject columnPrefab;
public int poolSize=5;
private GameObject[] columns=new GameObject[5];
private int columnCount=0; 
private float timeSinceLastSpawn=0f;
public float spawnRate=3f;


void Start()
{
    for(int i=0;i<poolSize;i++)
    {
        columns[i]= Instantiate(columnPrefab,new Vector2(Random.Range(-15f,-10f),0)
           ,Quaternion.identity) as GameObject;
    }
}

void Update()
{
    timeSinceLastSpawn+=Time.deltaTime;
    if(!BirdController.isDead && timeSinceLastSpawn >spawnRate)
    {
      Vector3 columnPos=new Vector3(10,Random.Range(-3f,3f),0);
      columns[columnCount].transform.position=columnPos;
      columnCount++;
      timeSinceLastSpawn=Time.deltaTime;
      if(columnCount>4)
      {columnCount=0;}
    }
    else
    {
       return;
    }
}


}
