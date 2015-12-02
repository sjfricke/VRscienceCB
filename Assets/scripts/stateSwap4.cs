using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stateSwap4 : MonoBehaviour {

	int timer = 0;
	const int cycle = 250;
	const int stage1 = 1 * cycle;
	const int stage2 = 2 * cycle;
	const int stage3 = 3 * cycle;
	GameObject Pair1;
	GameObject LonePair1;
	GameObject Pair2;
	GameObject LonePair2;

	Text textStatus;
	Text bondStatus;
	Text textStatus2;
	Text bondStatus2;

	// Use this for initialization
	void Start () {
		
		Pair1 = transform.Find("Pair1").gameObject;
		LonePair1 = transform.Find("LonePair1").gameObject;
		Pair2 = transform.Find("Pair2").gameObject;
		LonePair2 = transform.Find("LonePair2").gameObject;

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
			textStatus.text = "Trigonal Pyramid";
			bondStatus.text = "4 Bonds\n1 Lone Pairs";
			textStatus2.text = "Trigonal Pyramid";
			bondStatus2.text = "4 Bonds\n1 Lone Pairs";
			break;
		case stage2:
			Pair2.SetActive(false);
			LonePair2.SetActive(true);
			textStatus.text = "Bent";
			bondStatus.text = "4 Bonds\n2 Lone Pairs";
			textStatus2.text = "Bent";
			bondStatus2.text = "4 Bonds\n2 Lone Pairs";
			break;
		case stage3:
			Pair1.SetActive(true);
			Pair2.SetActive(true);
			LonePair1.SetActive(false);
			LonePair2.SetActive(false);
			textStatus.text = "Tetrahedral";
			bondStatus.text = "4 Bonds\n0 Lone Pairs";
			textStatus2.text = "Tetrahedral";
			bondStatus2.text = "4 Bonds\n0 Lone Pairs";
			timer = 0;
			break;
			
		}
		
		
		timer++;
	}
}
