using UnityEngine;
using System.Collections;
using System;

public class CameraStages3 : MonoBehaviour {

//	public float xMax;
//	public float yMax;
//	public float zMax;
	double xMax = 13.7;
	double yMax = 6.2;
	double zMax = 33.4;
	double xMin = -14;
	double yMin = -6.2;
	double zMin = -6;

	double x,y,z;
	double x2,y2,z2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
			x = Math.Abs(Cardboard.Controller.transform.eulerAngles.x % 360);
			y = Math.Abs(Cardboard.Controller.transform.eulerAngles.y % 360); 
			z = Math.Abs(Cardboard.Controller.transform.eulerAngles.z % 360);
			
			x2 = Math.Sin(y * (Math.PI / 180.0));
			y2 = Math.Sin(x * (Math.PI / 180.0)) * -1;
			z2 = ((Math.Cos(y * (Math.PI / 180.0))) * (Math.Cos(x * (Math.PI / 180.0)))) ;
			
			if (transform.position.x >= xMax ) {
				x2 = -2;
			}
			else if (transform.position.x <= xMin) {
				x2 = 2;
			}
			else if (transform.position.y >= yMax ) {
				y2 = -2;
			}
			else if (transform.position.y <= yMin) {
				y2 = 2;
			}
			else if (transform.position.z >= zMax ) {
				z2 = -2;
			}
			else if (transform.position.z <= zMin) {
				z2 = 2;
			}


			Vector3 move = new Vector3 ((float)x2 / 4, (float)y2 / 4, (float)z2 / 4);

			transform.position += move;
		}
	}
}
