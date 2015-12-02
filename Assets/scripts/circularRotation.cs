using UnityEngine;
using System.Collections;

public class circularRotation : MonoBehaviour {

	float angle =0;
	float speed = (2 * Mathf.PI) / 2; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	public float radius = 500;
	float x;
	float y;
	float z;
	void Update()
	{

		angle += speed *Time.deltaTime; //if you want to switch direction, use -= instead of +=
		x = Mathf.Cos(angle)*radius;
		y = Mathf.Cos(angle)*radius;
		z = Mathf.Cos(angle)*radius;
		print (new Vector3(x,y,z));
		transform.Rotate(new Vector3(x,y,z) * Time.deltaTime);
	}
}
