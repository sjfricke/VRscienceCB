using UnityEngine;
using System.Collections;

public class CameraStages2 : MonoBehaviour {
	
	Animator anim;
	private int state = 1;
	float startTime = 0;
	
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	
	void Update ()
	{
		startTime += Time.deltaTime;

		if (Input.GetMouseButtonDown (0) && state == 1 && startTime > .5 ) { 
			startTime = 0;
			anim.Play("Stage0");
			state++;
		}
		
		else if (Input.GetMouseButtonDown (0) && state == 2 && startTime > 2 ) { 
			startTime = 0;
			anim.Play("Stage1");
			state++;
		}
		
		else if (Input.GetMouseButtonDown (0) && state == 3 && startTime > 2 ) { 
			startTime = 0;
			anim.Play("Stage2");
			state++;
		}
		
		else if (Input.GetMouseButtonDown (0) && state == 4 && startTime > 2 ) { 
			startTime = 0;
			anim.Play("Stage3");
			state++;
		}
		
		else if (Input.GetMouseButtonDown (0) && state == 5 && startTime > 2 ) { 
			startTime = 0;
			anim.Play("Stage4");
			state = 1;			
		}
	}
}
