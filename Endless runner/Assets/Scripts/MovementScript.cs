using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{

		float moveX;
		public float jumpStrength;
		public float horizontalSpeed;
		public float gravity;
		public bool grounded = false;
		// Use this for initialization
	
		void FixedUpdate ()
		{
		
				moveX = Input.GetAxisRaw ("Horizontal");
		
				gravity = rigidbody.velocity.y;
		
				//Movement speed and apply gravity to rigidbody
				rigidbody.velocity = new Vector3 (moveX * horizontalSpeed, gravity, 0);
		
	
		}
	
	
	
		// Update is called once per frame
		void Update ()
		{
	
				if (Input.GetButtonDown ("Jump") && grounded == true) {
						rigidbody.velocity += new Vector3 (0, jumpStrength, 0);	
				}
	
				//Makes the player able to slam down
				else if (Input.GetButtonDown ("Jump") && !grounded) {
						rigidbody.AddForce (Vector3.down * 600);
				}	
	
		}
	
		void OnCollisionEnter (Collision col)
		{

				grounded = true;

		}
	
		void OnCollisionStay (Collision col)
		{

				grounded = true;

		}
	
		void OnCollisionExit (Collision col)
		{
		
				grounded = false;
		}
}
