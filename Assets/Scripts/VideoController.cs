using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    private VideoPlayer VideoPlayer;
    // Start is called before the first frame update

    public VideoController() {
    }
    
    void Start()
    {
        VideoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
