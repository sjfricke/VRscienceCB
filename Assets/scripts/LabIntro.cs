using UnityEngine;
using System.Collections;

public class LabIntro : MonoBehaviour {

	public GameObject periodicTable;
	public GameObject atomicMass;
	public GameObject lithum;
	public GameObject lithum2;
	public GameObject lithum3;
	public GameObject lithum4;
	public GameObject lithum5;
	public GameObject lithum6;

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
				anim = atomicMass.GetComponent<Animator>();	
				anim.Play("InfoAtomicMass");
			} else if (stage == 2 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1){
				anim = periodicTable.GetComponent<Animator>();
				atomicMass.SetActive(false);
				stage++;
				anim.Play("Periodic1");
			} else if (stage == 3 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1){
				stage++;
				anim.Play("Periodic2");


			} else if (stage == 4 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1) {
				anim = lithum.GetComponent<Animator>();	
				stage++;
				anim.Play("drop");
				anim = lithum2.GetComponent<Animator>();	
				anim.Play("drop");
				anim = lithum3.GetComponent<Animator>();	
				anim.Play("drop");
				anim = lithum4.GetComponent<Animator>();	
				anim.Play("drop");
				anim = lithum5.GetComponent<Animator>();	
				anim.Play("drop");
				anim = lithum6.GetComponent<Animator>();	
				anim.Play("drop");
								
			} else if (stage == 5 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1){
				Application.LoadLevel("MassSpectrometer");
			}
		}
	}
}
