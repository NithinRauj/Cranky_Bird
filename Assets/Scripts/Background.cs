using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

void OnTriggerExit2D(Collider2D collider)
{
    Destroy(collider.gameObject);
    GameManager.hasDied=true;
}
	
}

