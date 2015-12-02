using UnityEngine;
using System.Collections;

public class startAnimation : MonoBehaviour {
	private Animator anim;		// Reference to the animator component.
	private GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		anim = GetComponent<Animator>();
		anim.SetBool ("Go", true);
		anim.Play ("Go");
	}	

}
