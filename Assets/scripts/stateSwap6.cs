using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stateSwap6 : MonoBehaviour {

	int timer = 0;
	const int cycle = 250;
	const int stage1 = 1 * cycle;
	const int stage2 = 2 * cycle;
	const int stage3 = 3 * cycle;
	const int stage4 = 4 * cycle;
	const int stage5 = 5 * cycle;
	GameObject Pair1;
	GameObject LonePair1;
	GameObject Pair2;
	GameObject LonePair2;
	GameObject Pair3;
	GameObject LonePair3;
	GameObject Pair4;
	GameObject LonePair4;

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
		Pair3 = transform.Find("Pair3").gameObject;
		LonePair3 = transform.Find("LonePair3").gameObject;
		Pair4 = transform.Find("Pair4").gameObject;
		LonePair4 = transform.Find("LonePair4").gameObject;

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
			textStatus.text = "Square Pyramid";
			bondStatus.text = "6 Bonds\n1 Lone Pairs";
			textStatus2.text = "Square Pyramid";
			bondStatus2.text = "6 Bonds\n1 Lone Pairs";
			break;
		case stage2:
			Pair2.SetActive(false);
			LonePair2.SetActive(true);
			textStatus.text = "Square Planar";
			bondStatus.text = "6 Bonds\n2 Lone Pairs";
			textStatus2.text = "Square Planar";
			bondStatus2.text = "6 Bonds\n2 Lone Pairs";
			break;
		case stage3:
			Pair3.SetActive(false);
			LonePair3.SetActive(true);
			textStatus.text = "T-Shape";
			bondStatus.text = "6 Bonds\n3 Lone Pairs";
			textStatus2.text = "T-Shape";
			bondStatus2.text = "6 Bonds\n3 Lone Pairs";
			break;	
		case stage4:
			Pair4.SetActive(false);
			LonePair4.SetActive(true);
			textStatus.text = "Linear";
			bondStatus.text = "6 Bonds\n4 Lone Pairs";
			textStatus2.text = "Linear";
			bondStatus2.text = "6 Bonds\n4 Lone Pairs";
			break;
		case stage5:
			Pair1.SetActive(true);
			Pair2.SetActive(true);
			Pair3.SetActive(true);
			Pair4.SetActive(true);
			LonePair1.SetActive(false);
			LonePair2.SetActive(false);
			LonePair3.SetActive(false);
			LonePair4.SetActive(false);
			textStatus.text = "Octahedral";
			bondStatus.text = "6 Bonds\n0 Lone Pairs";
			textStatus2.text = "Octahedral";
			bondStatus2.text = "6 Bonds\n0 Lone Pairs";
			timer = 0;
			break;
			
		}
		
		
		timer++;
	}
}
