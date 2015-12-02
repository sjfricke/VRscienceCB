using UnityEngine;
using System.Collections;

public class rotateX : MonoBehaviour {

	public int speed = 45;
	
	void Update ()
	{
		transform.Rotate(new Vector3(speed,0,0) * Time.deltaTime);
	}
}
