using UnityEngine;
using System.Collections;

public class LabIntro : MonoBehaviour {
//	anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1
	public GameObject periodicTable;
	public GameObject atomicMass;
	public GameObject lithum;
	public GameObject lithum2;
	public GameObject lithum3;
	public GameObject lithum4;
	public GameObject lithum5;
	public GameObject lithum6;

	public AudioSource audio0;
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;

	Animator anim;
	Animation animationCurrent;
	private int stage = 0;
	
	float startTime = 0;
	// Use this for initialization
	void Start () {
        anim = atomicMass.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {		

		startTime += Time.deltaTime;
		if (startTime > 2 && stage == 0) {
			audio0.Play();
			stage++;
		}

		if (Input.GetMouseButton (0)) {

			if (stage == 1 && !audio0.isPlaying) {
				stage++;
				anim = atomicMass.GetComponent<Animator>();	
				audio1.Play();
				anim.Play("InfoAtomicMass");
			} else if (stage == 2 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1 && !audio1.isPlaying){
				anim = periodicTable.GetComponent<Animator>();
				atomicMass.SetActive(false);
				stage++;
				audio2.Play();
				anim.Play("Periodic1");
			} else if (stage == 3 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1 && !audio2.isPlaying){
				stage++;
				anim.Play("Periodic2");
				anim = lithum.GetComponent<Animator>();				
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
				audio3.Play();
				 								
			} else if (stage == 4 && anim.GetCurrentAnimatorStateInfo (0).normalizedTime > 1 && !audio3.isPlaying){
				Application.LoadLevel("MassSpectrometer");
			}
		}
	}
}
