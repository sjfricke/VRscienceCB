using UnityEngine;
using System.Collections;
using System;


public class movement : MonoBehaviour {
	double x,y,z;
	double x2,y2,z2;
	public GameObject eye;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetMouseButton (0)) {
			x = Math.Abs(Camera.main.transform.rotation.eulerAngles.x % 360);
			y = Math.Abs(Camera.main.transform.rotation.eulerAngles.y % 360); 
			z = Math.Abs(Camera.main.transform.rotation.eulerAngles.z % 360);

			x2 = Math.Sin(y * (Math.PI / 180.0));
			y2 = Math.Sin(x * (Math.PI / 180.0)) * -1;
			z2 = ((Math.Cos(y * (Math.PI / 180.0))) * (Math.Cos(x * (Math.PI / 180.0)))) ;

		
			Vector3 move = new Vector3 ((float)x2 / 3, (float)y2 /3 , (float)z2 /3);
			transform.position += move;
//			Cardboard.SDK.transform.position += move;
//			Cardboard.Controller.camera.transform.position += move;
		}
	}


}


