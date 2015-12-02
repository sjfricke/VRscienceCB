using UnityEngine;
using System.Collections;

public class rotateY : MonoBehaviour {

	public int speed = 45;
	
	void Update ()
	{
		transform.Rotate(new Vector3(0,speed,0) * Time.deltaTime);
	}
}
