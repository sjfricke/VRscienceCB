using UnityEngine;
using System.Collections;

public class rotateRing2 : MonoBehaviour {

	public int speed = 45;
	
	void Update ()
	{
		transform.Rotate(new Vector3(speed, 0, speed/2) * Time.deltaTime);
	}
}
