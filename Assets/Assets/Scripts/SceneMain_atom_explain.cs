using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneMain_atom_explain : MonoBehaviour {

    private GameObject carbonTable;
    private GameObject carbon12Math;
    private GameObject carbon14Math;
    private GameObject neutronContainer;
    private GameObject sampleAtoms;
    private GameObject atomContainer;
    
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;

    private int currentState = 0;

    // Use this for initialization
    void Start () {
        
        //Grabs Objects
        carbonTable = GameObject.Find("carbonTable");
        carbon12Math = GameObject.Find("carbon12Math");
        carbon14Math = GameObject.Find("carbon14Math");
        neutronContainer = GameObject.Find("neutronContainer");
        sampleAtoms = GameObject.Find("sampleAtoms");
        atomContainer = GameObject.Find("atomContainer");

        //turns off first set of objects
        carbon12Math.SetActive(false);
        carbon14Math.SetActive(false);
        neutronContainer.SetActive(false);
        sampleAtoms.SetActive(false);
        atomContainer.SetActive(false);

        
        StartCoroutine(WaitToStart());


    }
	
	// Update is called once per frame
	void Update () {
        //if (currentState == 0) StartCoroutine(WaitToStart());
        if (currentState == 1) State1();
        else if (currentState == 2) State2();
        else if (currentState == 3) State3();
        else if (currentState == 4) State4();
        else if (currentState == 5) State5();
        else if (currentState == 6) State6();
        else if (currentState == 7) State7();
        else if (currentState == 8) State8();
        else if (currentState == 9) State9();
    }

    void State1()
    {
        audio1.Play();
        currentState = 2;

    }

    void State2()
    {
        if (!audio1.isPlaying)
        {
            currentState = 3;
            atomContainer.SetActive(true);
        }

    }

    void State3()
    {
        audio2.PlayDelayed(3);
        atomContainer.GetComponent<Animator>().Play("atomDropIn");
        currentState = 4;
    }

    void State4()
    {
        if (!audio2.isPlaying)
        {
            currentState = 5;
            sampleAtoms.SetActive(true);
            carbon12Math.SetActive(true);
            carbonTable.GetComponent<Animator>().Play("bringOutCarbonTable");
            audio3.PlayDelayed(3);
        }

    }

    void State5()
    {
        if (!audio3.isPlaying)
        {
            currentState = 6;
            carbon14Math.SetActive(true);
            neutronContainer.SetActive(true);
            carbon12Math.SetActive(false);
            neutronContainer.GetComponent<Animator>().Play("addTwoNeutrons");
            audio4.PlayDelayed(3);
        }
    }
    void State6()
    {
        if (!audio4.isPlaying)
        {
            currentState = 7;
            audio5.PlayDelayed(4);
        }
    }
    void State7()
    {

    }
    void State8()
    {

    }
    void State9()
    {

    }

    public void resetStates()
    {
        SceneManager.LoadScene("atom_explain");
    }

   
    IEnumerator WaitToStart()
    {
        yield return new WaitForSeconds(2f);
        currentState = 1;
    }
}
