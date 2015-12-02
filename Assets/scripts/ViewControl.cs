using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViewControl : MonoBehaviour {

	public GameObject View1;
	public GameObject View2;
	public GameObject View3;
	public GameObject View4;
	public GameObject View5;

	public Text textStatus;
	public Text bondStatus;
	public Text textStatus2;
	public Text bondStatus2;

	public GameObject camera;
	private int viewState = 1;
	private Vector3 centerPosition = new Vector3(0,0,0);
	private Vector3 centerRotation = new Vector3(0,0,90);
	private Vector3 outerPosition = new Vector3((float)7.57, (float)3.3, (float)-6.32);
	private Vector3 outerRotation = new Vector3((float)20.5, (float)305.55, (float)1.6);
	int timeout = 61;
	float holdCount = 0;
	bool longClickDone;
	bool click;
	int stateView = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0) && timeout > 60) {
 			timeout = 0;

				
			holdCount = Time.time;
			click = true;
			longClickDone = false;
		
		}

		if (click && !longClickDone && (Time.time - holdCount) > 0.6) {
			longClickDone = true;

			GameObject.FindGameObjectWithTag ("CentralAtom").renderer.enabled = true;

			stateView++;
			if (stateView > 5)
				stateView = 1;
			switch (stateView) {
			case 1:
				//linear on
				View5.SetActive (false);
				View1.SetActive (true);
				textStatus.text = "Linear";
				bondStatus.text = "2 Bonds\n0 Lone Pairs";
				textStatus2.text = "Linear";
				bondStatus2.text = "2 Bonds\n0 Lone Pairs";
				break;
			case 2:
				//Trig Planer on
				View1.SetActive (false);
				View2.SetActive (true);
				textStatus.text = "Trigonal Planar";
				bondStatus.text = "3 Bonds\n0 Lone Pairs";
				textStatus2.text = "Trigonal Planar";
				bondStatus2.text = "3 Bonds\n0 Lone Pairs";
				break;
			case 3:
				//Tetraheadral
				View2.SetActive (false);
				View3.SetActive (true);
				textStatus.text = "Tetrahedral";
				bondStatus.text = "4 Bonds\n0 Lone Pairs";
				textStatus2.text = "Tetrahedral";
				bondStatus2.text = "4 Bonds\n0 Lone Pairs";
				break;
			case 4:
				//Trig Byprymidal
				View3.SetActive (false);
				View4.SetActive (true);
				textStatus.text = "Trigonal Bipyramid";
				bondStatus.text = "5 Bonds\n0 Lone Pairs";
				textStatus2.text = "Trigonal Bipyramid";
				bondStatus2.text = "5 Bonds\n0 Lone Pairs";
				break;
			case 5:
				//Octahdral
				View4.SetActive (false);
				View5.SetActive (true);
				textStatus.text = "Octahedral";
				bondStatus.text = "6 Bonds\n0 Lone Pairs";
				textStatus2.text = "Octahedral";
				bondStatus2.text = "6 Bonds\n0 Lone Pairs";
				break;
				
			}
			fixRotation();
			if (viewState == 2){
				(GameObject.FindGameObjectWithTag ("Atom").GetComponent ("rotateAll") as MonoBehaviour).enabled = false;
			}

			
		}
		
		if (Input.GetMouseButtonUp (0)) {
			click = false;
			if ((Time.time - holdCount) <= 0.6) {
				GameObject centralAtom = GameObject.FindGameObjectWithTag ("CentralAtom");
				GameObject atom = GameObject.FindGameObjectWithTag ("Atom");
				if (viewState == 1) {
					viewState = 2;
					camera.transform.position = centerPosition;
					camera.transform.rotation = Quaternion.identity;

					fixRotation();

					(atom.GetComponent ("rotateAll") as MonoBehaviour).enabled = false;
					centralAtom.renderer.enabled = false;
				} else {
					viewState = 1;
					camera.transform.position = outerPosition;	
					camera.transform.localEulerAngles = outerRotation;
					(atom.GetComponent ("rotateAll") as MonoBehaviour).enabled = true;
					centralAtom.renderer.enabled = true;
				}
			}
	
		}
			
		timeout++;
	}

	void fixRotation() {
		GameObject atom = GameObject.FindGameObjectWithTag ("Atom");
		if (stateView == 1){
			atom.transform.localEulerAngles = new Vector3(0,0,0);
		}
		if (stateView == 2){
			atom.transform.localEulerAngles  = new Vector3(-90,0,0);
		}
		if (stateView == 3){
			atom.transform.localEulerAngles = new Vector3((float)-0.4917781, (float)0.1930729, (float)1.019383);
		}
		if (stateView == 4){
			atom.transform.localEulerAngles  = new Vector3((float)87.1689, (float)143.2793, (float)143.2202);
		}
		if (stateView == 5){
			atom.transform.localEulerAngles  = new Vector3((float)0.04262478, (float)0.02667236, (float)1.81311);
		}
	}
}
