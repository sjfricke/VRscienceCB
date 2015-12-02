using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stateSwap3 : MonoBehaviour {
	int timer = 0;
	const int cycle = 250;
	const int stage1 = 1 * cycle;
	const int stage2 = 2 * cycle;
	GameObject Pair1;
	GameObject LonePair1;

	Text textStatus;
	Text bondStatus;
	Text textStatus2;
	Text bondStatus2;
	
	
	// Use this for initialization
	void Start () {
		
		Pair1 = transform.Find("Pair1").gameObject;
		LonePair1 = transform.Find("LonePair1").gameObject;

		textStatus = GameObject.Find ("MainScript").GetComponent<ViewControl> ().textStatus;
		bondStatus = GameObject.Find ("MainScript").GetComponent<ViewControl> ().bondStatus;
		textStatus2 = GameObject.Find ("MainScript").GetComponent<ViewControl> ().textStatus2;
		bondStatus2 = GameObject.Find ("MainScript").GetComponent<ViewControl> ().bondStatus2;
	}
	
	// Update is called once per frame
	void Update () {
		
		switch (timer) {
		case stage1:
			Pair1.SetActive(false);
			LonePair1.SetActive(true);
			textStatus.text = "Bent";
			bondStatus.text = "3 Bonds\n1 Lone Pairs";
			textStatus2.text = "Bent";
			bondStatus2.text = "3 Bonds\n1 Lone Pairs";
			break;
		case stage2:
			Pair1.SetActive(true);
			LonePair1.SetActive(false);
			textStatus.text = "Trigonal Planar";
			bondStatus.text = "3 Bonds\n0 Lone Pairs";
			textStatus2.text = "Bent";
			bondStatus2.text = "3 Bonds\n1 Lone Pairs";
			timer = 0;
			break;
			
		}
		
		
		timer++;
	}
}
