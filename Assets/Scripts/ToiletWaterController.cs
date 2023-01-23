using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletWaterController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    private float _flushTime = 5.0f;
    private bool _isFlushing = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_isFlushing)
        {
            _particleSystem.transform.Rotate(0, 0, 2);
        }
    }

    public void FlushToilet()
    {
        StartCoroutine(Flush());
    }

    private IEnumerator Flush()
    {
        _particleSystem.Play();
        _isFlushing = true;
        yield return new WaitForSeconds(_flushTime);
        _particleSystem.Stop();
        _isFlushing = false;
    }
}
