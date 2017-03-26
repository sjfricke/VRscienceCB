using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class dig_site_events : MonoBehaviour {

    static private int fossilClickCount = 0;

    private GameObject fossil_GO;

    public AudioSource audio2;

    // Use this for initialization
    void Start () {
        

        fossil_GO = GameObject.Find("fossil_animation");
        fossil_GO.SetActive(false);
        fossilClickCount = 0;

    }
	
	// Update is called once per frame
	void Update () {
	}

    public void gotoAtomExplainScene()
    {
        SceneManager.LoadScene("atom_explain");
    }

    public void gotoMassSpecScene()
    {
        if (fossilClickCount == 0)
        {
            fossil_GO.SetActive(true);
            fossil_GO.GetComponent<Animator>().Play("pickFossilSample");
            audio2.Play();
            fossilClickCount++;
        } else if (fossilClickCount == 1 && !audio2.isPlaying)
        {
            SceneManager.LoadScene("mass_spectrometer");
        }
    }
}
