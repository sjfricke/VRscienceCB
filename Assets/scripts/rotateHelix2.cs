using UnityEngine;
using System.Collections;

public class rotateHelix2 : MonoBehaviour {

	public int speed = 40;

	void Update ()
	{
		transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
	}
}
