using UnityEngine;
using System.Collections;

public class switchView : MonoBehaviour {

	Vector3 startingPosition = new Vector3 (-17, -4, -8);
	Vector3 position1 = new Vector3 (-53, 2, -2);
	Vector3 position2 = new Vector3 (-18, -4, 22);
	Vector3 position3 = new Vector3 (15, 1, -3);
	int position = 1;
	int timeout = 100;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0) && timeout >= 60) {
			timeout = 0;
			switch (position) {
			case 1:
				transform.position = position1;
				position++;
				break;
			case 2:
				transform.position = position2;
				position++;
				break;
			case 3:
				transform.position = position3;
				position++;
				break;
			case 4:
				transform.position = startingPosition;
				position = 1;
				break;

			}
		} else { 
			timeout++;
		}
	
	}
}
