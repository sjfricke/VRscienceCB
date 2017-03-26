using UnityEngine;
using System.Collections;

public class SceneMain_MassSpec : MonoBehaviour {

    // public GameObject Enviroment;

    //materials for location marker looking toggling
    public Material noLookMarker;
    public Material lookMarker;

    //current marker index
    private int currentMarker;

    //struct for all the marker gameobjects
    private struct markers
    {
        public GameObject marker0;
        public GameObject marker1;
        public GameObject marker2;
        public GameObject marker3;
        public GameObject marker4;
        public GameObject marker5;
        public GameObject marker4_2;

    };

    //struct for all the marker in terms where the camera should be
    //also use for audio as they are in same location
    private struct cameraLocationsAudio
    {
        public GameObject location0;
        public GameObject location1;
        public GameObject location2;
        public GameObject location3;
        public GameObject location4;
        public GameObject location5;
    };

    //used as an ISR for moving
    private bool movingLocal = false;
    
    private markers marker;
    private cameraLocationsAudio location;

    // Use this for initialization
    void Start () {
        //set Markers
        marker.marker0 = GameObject.Find("locationMarker (0)");
        marker.marker1 = GameObject.Find("locationMarker (1)");
        marker.marker2 = GameObject.Find("locationMarker (2)");
        marker.marker3 = GameObject.Find("locationMarker (3)");
        marker.marker4 = GameObject.Find("locationMarker (4)");
        marker.marker5 = GameObject.Find("locationMarker (5)");
        marker.marker4_2 = GameObject.Find("locationMarker (4_2)");

        //set locations of camera positions
        location.location0 = GameObject.Find("mass_spec_audio_1");
        location.location1 = GameObject.Find("mass_spec_audio_2");
        location.location2 = GameObject.Find("mass_spec_audio_3");
        location.location3 = GameObject.Find("mass_spec_audio_4");
        location.location4 = GameObject.Find("mass_spec_audio_5");
        location.location5 = GameObject.Find("mass_spec_audio_6");

        //turn off all but marker 1 because we are on 0 and only 1 is seen
        currentMarker = 0;
        turnOffMarker(0);
        turnOffMarker(2);
        turnOffMarker(3);
        turnOffMarker(4);
        turnOffMarker(5);


        location.location0.GetComponent<AudioSource>().PlayDelayed(1f);

    }
	
	// Update is called once per frame
	void Update () {

        if (movingLocal)
        {
            if (!PlayerMover.Instance.Moving)
            {
                movingLocal = false;
                playAudio(currentMarker);
            }
        }

        //Enviroment.transform.Rotate(new Vector3(0, 1f, 0) * Time.deltaTime);
    }

    public void moveToMarker(int markerIndex)
    {
        if (PlayerMover.Instance.Moving) { return; }
        if (checkAudio()) { return;  }

        turnOffMarker(markerIndex);
        turnOnMarker(markerIndex + 1);
        turnOnMarker(markerIndex - 1);

        //turns off adjancent marker we are moving away from now
        if (markerIndex > currentMarker)
        {
            turnOffMarker(currentMarker - 1);
        } else
        {
            turnOffMarker(currentMarker + 1);
        }

        //tells main update we are moving
        movingLocal = true;

        switch (markerIndex)
        {
            case 0:
                PlayerMover.Instance.SetTargetPosition(location.location0.transform.position, location.location0);
                break;
            case 1:
                PlayerMover.Instance.SetTargetPosition(location.location1.transform.position, location.location1);
                break;
            case 2:
                PlayerMover.Instance.SetTargetPosition(location.location2.transform.position, location.location2);
                break;
            case 3:
                PlayerMover.Instance.SetTargetPosition(location.location3.transform.position, location.location3);
                break;
            case 4:
                if (currentMarker == 5)
                {
                    PlayerMover.Instance.SetTarget(location.location4);
                }
                else {
                    PlayerMover.Instance.SetTargetPosition(location.location4.transform.position, location.location4);
                }
                break;
            case 5:
                PlayerMover.Instance.SetTarget(location.location5);
                break;
        }


        //set new current
        currentMarker = markerIndex;
        
    }
    
    //returns true if audio is playing
    public bool checkAudio()
    {
        if (location.location0.GetComponent<AudioSource>().isPlaying) { return true;}
        else if (location.location1.GetComponent<AudioSource>().isPlaying) { return true; }
        else if (location.location2.GetComponent<AudioSource>().isPlaying) { return true; }
        else if (location.location3.GetComponent<AudioSource>().isPlaying) { return true; }
        else if (location.location4.GetComponent<AudioSource>().isPlaying) { return true; }
        else if (location.location5.GetComponent<AudioSource>().isPlaying) { return true; }
        else { return false; }
    }

    public void playAudio(int markerIndex)
    {

        //used because menu UI can't pass current index
        if (markerIndex == -1) { markerIndex = currentMarker; }

        switch (markerIndex)
        {
            case 0:
                if (location.location0.GetComponent<AudioSource>().isPlaying)
                {
                    location.location0.GetComponent<AudioSource>().Stop();
                }
                    location.location0.GetComponent<AudioSource>().Play();
                 break;
            case 1:
                if (location.location1.GetComponent<AudioSource>().isPlaying)
                {
                    location.location1.GetComponent<AudioSource>().Stop();
                }
                location.location1.GetComponent<AudioSource>().Play();
                break;
            case 2:
                if (location.location2.GetComponent<AudioSource>().isPlaying)
                {
                    location.location2.GetComponent<AudioSource>().Stop();
                }
                location.location2.GetComponent<AudioSource>().Play();
                break;
            case 3:
                if (location.location3.GetComponent<AudioSource>().isPlaying)
                {
                    location.location3.GetComponent<AudioSource>().Stop();
                }
                location.location3.GetComponent<AudioSource>().Play();
                break;
            case 4:
                if (location.location4.GetComponent<AudioSource>().isPlaying)
                {
                    location.location4.GetComponent<AudioSource>().Stop();
                }
                location.location4.GetComponent<AudioSource>().Play();
                break;
            case 5:
                if (location.location5.GetComponent<AudioSource>().isPlaying)
                {
                    location.location5.GetComponent<AudioSource>().Stop();
                }
                location.location5.GetComponent<AudioSource>().Play();
                break;
        }
    }

    public void seeMarker(int markerIndex)
    {
        switch (markerIndex)
        {
            case 0: marker.marker0.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    break;
            case 1: marker.marker1.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    break;
            case 2: marker.marker2.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    break;
            case 3: marker.marker3.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    break;
            case 4: marker.marker4.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    marker.marker4_2.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    break;
            case 5: marker.marker5.GetComponentInChildren<MeshRenderer>().material = noLookMarker;
                    break;
        }
    }
        
    public void unseeMarker(int markerIndex)
    {
        switch (markerIndex)
        {
            case 0: marker.marker0.GetComponentInChildren<MeshRenderer>().material = lookMarker;
                break;
            case 1: marker.marker1.GetComponentInChildren<MeshRenderer>().material = lookMarker;
                break;
            case 2: marker.marker2.GetComponentInChildren<MeshRenderer>().material = lookMarker;
                break;
            case 3: marker.marker3.GetComponentInChildren<MeshRenderer>().material = lookMarker;
                break;
            case 4: marker.marker4.GetComponentInChildren<MeshRenderer>().material = lookMarker;
                marker.marker4_2.GetComponentInChildren<MeshRenderer>().material = lookMarker;
                break;
            case 5: marker.marker5.GetComponentInChildren<MeshRenderer>().material = lookMarker;                
                break;
        }
    }

    public void turnOffMarker(int markerIndex)
    {
        switch (markerIndex)
        {
            case 0: marker.marker0.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker0.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker0.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                break;
            case 1: marker.marker1.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker1.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker1.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                break;
            case 2: marker.marker2.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker2.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker2.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                break;
            case 3: marker.marker3.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker3.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker3.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                break;
            case 4: marker.marker4.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker4.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker4.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                    marker.marker4_2.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker4_2.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker4_2.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                break;
            case 5: marker.marker5.GetComponent<CapsuleCollider>().enabled = false;
                    marker.marker5.GetComponentsInChildren<MeshRenderer>()[0].enabled = false;
                    marker.marker5.GetComponentsInChildren<MeshRenderer>()[1].enabled = false;
                break;
        }
    }

    public void turnOnMarker(int markerIndex)
    {
        switch (markerIndex)
        {
            case 0:
                marker.marker0.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker0.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker0.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                break;
            case 1:
                marker.marker1.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker1.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker1.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                break;
            case 2:
                marker.marker2.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker2.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker2.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                break;
            case 3:
                marker.marker3.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker3.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker3.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                break;
            case 4:
                marker.marker4.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker4.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker4.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                marker.marker4_2.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker4_2.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker4_2.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                break;
            case 5:
                marker.marker5.GetComponent<CapsuleCollider>().enabled = true;
                marker.marker5.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                marker.marker5.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                break;
        }
    }

}
