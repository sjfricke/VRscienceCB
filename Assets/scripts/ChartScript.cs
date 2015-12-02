using UnityEngine;
using System.Collections;

public class ChartScript : MonoBehaviour {

	public GameObject box001;
	public GameObject box002;
	public GameObject box003;
	public GameObject box004;
	public GameObject box005;
	public GameObject box010;
	public GameObject box011;
	public GameObject box020;
	public GameObject box021;
	public GameObject box022;
	public GameObject box023;


	private float timeBeen = 0;
	// Use this for initialization
	void Start () {
		resetGO ();
	}
	
	// Update is called once per frame
	void Update () {
		timeBeen += Time.deltaTime;

		if (timeBeen > 6.850) {
			timeBeen = 0;
			resetGO();
		}
		else if (timeBeen > 6.45) {
			box005.renderer.enabled = true;
		} 
		else if (timeBeen > 6.08) {
			box004.renderer.enabled = true;
			box011.renderer.enabled = true;
		} 
		else if (timeBeen > 4.75) {
			box010.renderer.enabled = true;
		} 
		else if (timeBeen > 4.06) {
			box003.renderer.enabled = true;
		} 
		else if (timeBeen > 3.59) {
			box023.renderer.enabled = true;
		} 
		else if (timeBeen > 3.316) {
			box002.renderer.enabled = true;
		} 
		else if (timeBeen > 2.764) {
			box022.renderer.enabled = true;
		} 
		else if (timeBeen > 2.247) {
			box021.renderer.enabled = true;
		}
		else if (timeBeen > 1.130) {
			box001.renderer.enabled = true;
		} 
		else if (timeBeen > .6) {
			box020.renderer.enabled = true;
		} 
	}

	private void resetGO() {
		box001.renderer.enabled = false;
		box002.renderer.enabled = false;
		box003.renderer.enabled = false;
		box004.renderer.enabled = false;
		box005.renderer.enabled = false;
		box010.renderer.enabled = false;
		box011.renderer.enabled = false;
		box020.renderer.enabled = false;
		box021.renderer.enabled = false;
		box022.renderer.enabled = false;
		box023.renderer.enabled = false;

	}
}


