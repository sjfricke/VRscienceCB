using UnityEngine;
using System.Collections;

public class LabIntro : MonoBehaviour {

	public GameObject periodicTable;
	public GameObject atomicMass;

	Animator anim;
	Animation animationCurrent;
	private int stage = 1;
	// Use this for initialization
	void Start () {
		anim = atomicMass.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {		
		if (Input.GetMouseButton (0)) {
			if (stage == 1) {
				stage++;
				anim.Play("InfoAtomicMass");
			} else if (stage == 2 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1){
				anim = periodicTable.GetComponent<Animator>();
				atomicMass.SetActive(false);
				stage++;
				anim.Play("Periodic1");
			} else if (stage == 3 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1){
				stage++;
				anim.Play("Periodic2");
			
					} else if (stage == 4 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1){
						Application.LoadLevel("MassSpectrometer");
					}
		}
	}
}
