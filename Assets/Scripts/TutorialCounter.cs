using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialCounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI counterText;
    private int count = 1;

    public void IncrementCounter()
    {
        count++;
        counterText.text = count.ToString();
    }
}
