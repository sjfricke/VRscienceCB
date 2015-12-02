using UnityEngine;
using System.Collections;

public class rotateRing : MonoBehaviour {

	public int speed = 80;

	void Update ()
	{
		transform.Rotate(new Vector3(speed, 0, 0) * Time.deltaTime);
	}
}
