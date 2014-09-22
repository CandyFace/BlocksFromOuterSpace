using UnityEngine;
using System.Collections;

public class Highscore : MonoBehaviour {

	public static float score = 0;
	public static float highscore;
	public float totalscore;
	public GUISkin mySkin;

	void OnGUI()
	{
		//GUI.Label(new Rect(10, 10, 200, 20), "Highscore: "+ -scoreSpeed + " Km/hour");
		
		//Not neccesary.. 
		//GUI.Label (new Rect(Screen.width/2.8f,20,200,20),"Score: "+score.ToString());
		
		//call GUISkin and name it mySkin
		GUI.skin = mySkin;
		
		GUI.Label (new Rect(Screen.width/1.7f,20,600,100),"My Score: "+totalscore.ToString(), "label");
		GUI.Label (new Rect(Screen.width/5f,20,600,100),"Highscore: "+highscore.ToString(), "label");
	}
	


	
	void Update()
	{
			if(Application.loadedLevel == 1)
			{
				score += (int)10*Time.deltaTime;
			}
		
			totalscore = (int)score;
			
			if(highscore < totalscore)
			{
				highscore = totalscore;
			}
			
		
			
//			
		
	}
	
	
}
