using UnityEngine;
using System.Collections;

public class MenuMouseHandling : MonoBehaviour {

	
	void OnMouseDown()
	{	
				//On pressed, starts loading the Endless Runner game scene
				Highscore.score = 0;
				Application.LoadLevel("EndlessRunner");
		
	}
	
	void Update()
	{
		if(Input.anyKeyDown)
		{
				Highscore.score = 0;
				Application.LoadLevel("EndlessRunner");
		}
		
	}
	
}
