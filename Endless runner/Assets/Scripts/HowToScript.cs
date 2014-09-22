using UnityEngine;
using System.Collections;

public class HowToScript : MonoBehaviour {

	public GUISkin myskin;
	

	// Use this for initialization
	void OnGUI()
	{
		
		//call GUIskin class and name it mySkin
		GUI.skin = myskin;
	
		GUI.Label(new Rect (Screen.width/2.3f,Screen.height/2,200,100),"\t\t\tControl with A and D", "howTo");
		GUI.Label(new Rect (Screen.width/2.3f,Screen.height/1.9f,260,100),"Space to jump and double or more to slam", "howTo");
	}
}
