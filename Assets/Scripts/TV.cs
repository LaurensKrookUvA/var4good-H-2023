using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour
{
    private VideoPlayer _video;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void go()
    {
        _video = GetComponent<UnityEngine.Video.VideoPlayer>();
        if (_video.isPlaying) _video.Stop();
        else _video.Play();
    }
}
