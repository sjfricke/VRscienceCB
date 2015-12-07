using UnityEngine;
using System.Collections;

public class ChartScript : MonoBehaviour {

	public GameObject box601;
	public GameObject box602;
	public GameObject box603;

	public GameObject box701;
	public GameObject box702;
	public GameObject box703;
	public GameObject box704;
	public GameObject box705;

	public GameObject box801;
	public GameObject box802;


	private float timeBeen = 0;
	// Use this for initialization
	void Start () {
		resetGO ();
	}
	
	// Update is called once per frame
	void Update () {
		timeBeen += Time.deltaTime;

		if (timeBeen >= 8.567) {
			timeBeen = 0;
			resetGO();
		}
		else if (timeBeen > (.771 * 10)) {
			box705.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 9)) {
			box603.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 8)) {
			box802.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 7)) {
			box602.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 6)) {
			box704.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 5)) {
			box703.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 4)) {
			box801.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 3)) {
			box702.renderer.enabled = true;
		}
		else if (timeBeen > (.771 * 2)) {
			box601.renderer.enabled = true;
		} 
		else if (timeBeen > (.771 * 1)) {
			box701.renderer.enabled = true;
		} 
	}

	private void resetGO() {
		box601.renderer.enabled = false;
		box602.renderer.enabled = false;
		box603.renderer.enabled = false;
		box701.renderer.enabled = false;
		box702.renderer.enabled = false;
		box703.renderer.enabled = false;
		box704.renderer.enabled = false;
		box705.renderer.enabled = false;
		box801.renderer.enabled = false;
		box802.renderer.enabled = false;

	}
}


