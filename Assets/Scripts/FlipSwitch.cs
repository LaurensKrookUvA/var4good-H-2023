using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSwitch : MonoBehaviour
{
    public Animator anim;
    public Transform bone;
    bool isOn = true;
    
    public void playAnimation()
    {
        if (isOn == true)
        {
            anim.Play("SwitchOff-anim");
            Debug.Log("Switch Off");
            isOn = false;
        }
        else
        {
            anim.Play("SwitchOn-anim");
            Debug.Log("Switch On");
            isOn = true;
        }
    }

}
