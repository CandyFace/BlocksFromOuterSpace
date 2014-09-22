using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour {
	
	void OnTriggerEnter(Collider col)
	{
				Destroy (col.gameObject);
		
		if(col.gameObject.name == "Player")
		{
		
				platMove.speed = 0; //Kids this is horrible.. don't do it.
				Application.LoadLevel("Menu");
		}
		
	}
}
