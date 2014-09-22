using UnityEngine;
using System.Collections;

public class platMove : MonoBehaviour {
	
	public static float speed;
	
//	void FixedUpdate () {
//		
//		//Rigidbody can't be used in this case, the collision works differently when the objects are moving
//		//and not character.
//		//rigidbody.velocity = new Vector3(0,0,movementZ);
//		//transform.Translate(Vector3.forward * movementZ;
//		
//		
//	}

	void OnAwake()
	{
			speed = -2f;
	}
	
	void Update()
	{
	
			//use transform.Translate for all moving blocks.
			//no Time.deltatime = PEEEeeeeew!!! unless you want to break time continuum.
			speed += -0.4f*Time.deltaTime;
			transform.Translate(Vector3.forward * speed*Time.deltaTime);
			
	}
	
}
