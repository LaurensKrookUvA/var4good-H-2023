using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light _lamp; 
    private float _intensity;

    // Start is called before the first frame update
    void Start()
    {
        _lamp = GetComponent<Light>();
        _intensity = _lamp.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightSwitch()
    {
        if (_lamp.intensity < _intensity) _lamp.intensity = _intensity;
        else _lamp.intensity = 0;
    }
}
