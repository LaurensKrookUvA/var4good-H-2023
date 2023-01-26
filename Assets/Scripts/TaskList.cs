using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskList : MonoBehaviour
{
    private GameObject WashToggle;
    private GameObject DryToggle;
    private GameObject ShowerToggle;
    private GameObject EntertainToggle;
    private GameObject FoodToggle;
    private GameObject WorkToggle;
    
    void Start()
    {
        WashToggle = GameObject.Find("WashToggle");
        DryToggle = GameObject.Find("DryToggle");
        ShowerToggle = GameObject.Find("ShowerToggle");
        EntertainToggle = GameObject.Find("EntertainToggle");
        FoodToggle = GameObject.Find("FoodToggle");
        WorkToggle = GameObject.Find("WorkToggle");
    }

    public void Wash() {
        WashToggle.GetComponent<Toggle>().isOn = true;
    }

    public void Dry() {
        DryToggle.GetComponent<Toggle>().isOn = true;
    }

    public void Shower() {
        ShowerToggle.GetComponent<Toggle>().isOn = true;
    }

    public void Entertain() {
        EntertainToggle.GetComponent<Toggle>().isOn = true;
    }

    public void Food() {
        FoodToggle.GetComponent<Toggle>().isOn = true;
    }

    public void Work() {
        WorkToggle.GetComponent<Toggle>().isOn = true;
    }
}
