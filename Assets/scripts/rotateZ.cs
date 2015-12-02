using UnityEngine;
using System.Collections;

public class rotateZ : MonoBehaviour {

	public int speed = 45;
	
	void Update ()
	{
		transform.Rotate(new Vector3(0,0,speed) * Time.deltaTime);
	}
}
