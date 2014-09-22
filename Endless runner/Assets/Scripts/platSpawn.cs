using UnityEngine;
using System.Collections;

public class platSpawn : MonoBehaviour
{
		public GameObject newPlat;
		public float minTime;
		public float maxTime;

		void Start ()
		{
				Spawning ();
		}
	
		/// <summary>
		/// This function means doom, so please use it.
		/// also it spawns a new prefab at preferred destination
		/// </summary>
		void Spawning ()
		{
				//Can't declare and set as void, therefore declare a new Vector3.
				//Used for Instantiate
				Vector3 zGen = Vector3.zero;
				zGen.z = transform.position.z;
				zGen.x = transform.position.x;
				zGen.y = transform.position.y;
				zGen.y = Random.Range (0, 4);
				zGen.x = Random.Range (10, -10);
		
				//Instantiate (Object original, Vector position, Quaternion rotation);
				Instantiate (newPlat, zGen, transform.rotation);
		
				//determines my method and a time before running my function again.
				//Invoke ("method",t));
				Invoke ("Spawning", Random.Range (minTime, maxTime));
		}
}
