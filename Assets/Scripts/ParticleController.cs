using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleParticles()
    {
        if (_particleSystem.isPlaying) _particleSystem.Stop();
        else _particleSystem.Play();
        Debug.Log("Particles toggled " + _particleSystem.isPlaying);
    }
}
