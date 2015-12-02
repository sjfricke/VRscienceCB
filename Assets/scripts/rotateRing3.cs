using UnityEngine;
using System.Collections;

public class rotateRing3 : MonoBehaviour {

	public int speed = 45;
	
	void Update ()
	{
		transform.Rotate(new Vector3(speed, speed/2, 0) * Time.deltaTime);
	}
}