using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingLaundary : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    private ParticleSystem _particleSystem;
    private bool _spinning = false;

    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (_spinning) transform.Rotate(0, 0, speed);
    }

    public void Rotating()
    {
        _spinning = !_spinning;
        if (_spinning) _particleSystem.Play();
        else _particleSystem.Pause();
    }
}
