using UnityEngine;
using System.Collections;

public class SceneSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FullTour() {
		Application.LoadLevel("LabIntro");
	}

	public void NoAudio() {
		Application.LoadLevel("MassSpectrometerNoAudio");
	}

	public void FreeRoam() {
		Application.LoadLevel("MassSpectrometerFreeRoam");
	}
}
