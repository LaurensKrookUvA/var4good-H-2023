using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static Action minuteChange;
    public static Action hourChange;

    public static int Minute { get; private set; }
    public static int Hour { get; private set; }
    
    private float minuteToRealTime = 0.5f;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        Minute = 0;
        Hour = 8;
        timer = minuteToRealTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if day is over
        if (TimeManager.Hour == 24 && TimeManager.Minute == 00) {
            SceneManager.LoadScene("LevelEnd");
        }

        timer -= Time.deltaTime;

        if (timer <= 0) {
            Minute++;
            minuteChange?.Invoke();
            if (Minute >= 60) {
                Hour++;
                Minute = 0;
                hourChange?.Invoke();
            }

            timer = minuteToRealTime;
        }
    }
}
