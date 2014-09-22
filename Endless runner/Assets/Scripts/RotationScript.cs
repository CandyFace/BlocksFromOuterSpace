using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour
{

		public float speed;
		public Color colorStart;
		public Color colorEnd;
		float t = 0;
		float rate = 0.5f;
	
		// Use this for initialization
		void Start ()
		{
	
				colorStart = new Color (Random.value, Random.value, Random.value);
				colorEnd = new Color (Random.value, Random.value, Random.value);
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				t += rate * Time.deltaTime;
	
				speed += 0.5f * Time.deltaTime;
	
				transform.RotateAround (Vector3.zero, Vector3.back, speed * Time.deltaTime);
		
				if (speed > 30) {
						if (t >= 1) {
								t = 0;
								
								colorStart = renderer.material.color;
								colorEnd = new Color (Random.value, Random.value, Random.value);
						}
						renderer.material.color = Color.Lerp (colorStart, colorEnd, t);
				}
		
	
		}
}
