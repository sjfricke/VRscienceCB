using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuUI : MonoBehaviour {
    
    static public bool notLookedAt;
    public bool menu_instances;
    private Camera MainCamera;
    Vector3 currentRotation;
    public float yOffset = 0; //use offset when camera starts in different rotation
    private GameObject Menu_UI;

    static public bool VrModeToggle = true;


    // Use this for initialization
    void Start () {
        notLookedAt = true;
        Cardboard.SDK.VRModeEnabled = VrModeToggle;
        Menu_UI = GameObject.Find("Menu_UI");
        //MainCamera = GameObject.FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!menu_instances) return;
        if (notLookedAt)
        {
            //reset menu
            Menu_UI.transform.localRotation = Quaternion.identity;
            //get current look
            currentRotation = Camera.main.transform.rotation.eulerAngles;
                        //move menu
            //Rotate is z > x > y so need to do 2 operations
            Menu_UI.transform.Rotate(new Vector3(0f, currentRotation.y - yOffset, 0f));
            Menu_UI.transform.Rotate(new Vector3(37f, 0f, 0f));
        }

    }

    public void menuHovered_on ()
    {
        notLookedAt = false;
    }

    public void menuHovered_off ()
    {
        notLookedAt = true;
    }

    public void turnOnMesh()
    {
        this.GetComponent<MeshRenderer>().enabled = true;
    }

    public void turnOffMesh()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
    }


    public void VR_toggle()
    {
        VrModeToggle = !VrModeToggle;
        Cardboard.SDK.VRModeEnabled = VrModeToggle;
    }

    public void backToHome()
    {
        SceneManager.LoadScene("dig_site2_scene");
    }
}
