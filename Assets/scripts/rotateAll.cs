using UnityEngine;
using System.Collections;

public class rotateAll : MonoBehaviour {

	public int x = 45;
	public int y = 45;
	public int z = 45;

	
	void Update ()
	{
		transform.Rotate(new Vector3(x,y,z) * Time.deltaTime);
	}
}

