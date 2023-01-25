using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtains : MonoBehaviour
{
    [SerializeField] private float minScale = 0.26f;
    [SerializeField] private float maxScale = 0.5f;
    private float _initValue;

    void Start()
    {
        _initValue = transform.localScale.x;
    }
    public void Animation()
    {
      if (transform.localScale.x < maxScale)
      {
        transform.localScale = new Vector3 (minScale, transform.localScale.y, transform.localScale.z) + new Vector3 (maxScale, 0, 0);
      }
      else if (transform.localScale.x > minScale)
      {
        transform.localScale = new Vector3 (maxScale, transform.localScale.y, transform.localScale.z) - new Vector3 (minScale, 0, 0);
      }
    }
}
