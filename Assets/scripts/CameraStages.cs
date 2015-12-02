using UnityEngine;
using System.Collections;

public class CameraStages : MonoBehaviour {

	public AudioSource audio0;
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;
	public AudioSource audio4;

	Animator anim;
	private int state = 0;
	private bool restart;
	float startTime = 0;

	void Start ()
	{
		anim = GetComponent<Animator>();
		restart = false;
	}
	
	
	void Update ()
	{
		startTime += Time.deltaTime;
		if (startTime > 3 && state == 0) {
			audio0.Play();
			state++;
		}
		if (Input.GetMouseButtonDown (0) && state == 1 && !audio0.isPlaying) { 
			anim.Play("Stage0");
			state++;
			audio1.Play(88200);
		}

		if (Input.GetMouseButtonDown (0) && state == 2 && !audio1.isPlaying) { 
			anim.Play("Stage1");
			state++;
			audio2.Play(88200);
		}

		if (Input.GetMouseButtonDown (0) && state == 3 && !audio2.isPlaying) { 
			anim.Play("Stage2");
			state++;
			audio3.Play(88200);
		}

		if (Input.GetMouseButtonDown (0) && state == 4 && !audio3.isPlaying) { 
			anim.Play("Stage3");
			state++;
			audio4.Play(88200);
		}

		if (Input.GetMouseButtonDown (0) && state == 5 && !audio4.isPlaying) { 
			anim.Play("Stage4");
			state = 0;
			startTime = 0;

		}
	}
}
