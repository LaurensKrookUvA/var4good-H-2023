using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockUI : MonoBehaviour
{
    public TextMeshProUGUI ClockText;
    // private bool clockActive = true;
    private TextMeshProUGUI ButtonText;

    private void OnEnable() {
        TimeManager.minuteChange += UpdateTime;
        TimeManager.hourChange += UpdateTime;
    }

    private void OnDisable() {
        TimeManager.minuteChange += UpdateTime;
        TimeManager.hourChange += UpdateTime;
    }

    private void UpdateTime() {
        ClockText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }

    public void buttonPressed() {
        ButtonText.text = "pressed";
    }
}
