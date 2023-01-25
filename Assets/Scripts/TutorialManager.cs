using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject Screen;
    public GameObject Presentor;

    public void StartIntroduction()
    {
        Screen = GameObject.Find("Screen");
        Material screenMaterial = Screen.GetComponent<Renderer>().material;
        screenMaterial.color = Color.red;

        Presentor = GameObject.Find("Presentor");
        AudioManager audioManager = Presentor.GetComponent<AudioManager>();
        audioManager.Play("FirstLine");
    }

    public void StartFirstStep()
    {
        Screen = GameObject.Find("Screen");
        Material screenMaterial = Screen.GetComponent<Renderer>().material;
        screenMaterial.color = Color.green;

        Presentor = GameObject.Find("Presentor");
        AudioManager audioManager = Presentor.GetComponent<AudioManager>();
        audioManager.Play("SecondLine");
    }

    public void StartThirdStep()
    {
        Screen = GameObject.Find("Screen");
        Material screenMaterial = Screen.GetComponent<Renderer>().material;
        screenMaterial.color = Color.blue;

        Presentor = GameObject.Find("Presentor");
        AudioManager audioManager = Presentor.GetComponent<AudioManager>();
        audioManager.Play("ThirdLine");
    }

    public void StartEnd()
    {
        Screen = GameObject.Find("Screen");
        Material screenMaterial = Screen.GetComponent<Renderer>().material;
        screenMaterial.color = Color.black;

        Presentor = GameObject.Find("Presentor");
        AudioManager audioManager = Presentor.GetComponent<AudioManager>();
        audioManager.Play("EndLine");
    }
}
