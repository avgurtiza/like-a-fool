using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BeatController : MonoBehaviour
{
    protected GameObject BakaMitaiVid;
    
    private Dictionary<double, GameObject> beatMap;

    private double lastTime;

    public string TextMe;
    
    public GameObject KeyPrefabI;
    public GameObject KeyPrefabJ;
    public GameObject KeyPrefabK;
    public GameObject KeyPrefabL;


    // Start is called before the first frame update
    void Start()
    {
        beatMap =  new Dictionary<double, GameObject>();
        beatMap.Add(1.2d, KeyPrefabK);
        beatMap.Add(2.6d, KeyPrefabI);
        beatMap.Add(7.6d, KeyPrefabI);
        beatMap.Add(9d, KeyPrefabJ);
        beatMap.Add(11d, KeyPrefabK);
        
        BakaMitaiVid = GameObject.FindWithTag("SongVid");
    }

    // Update is called once per frame
    void Update()
    {
        var time = BakaMitaiVid.GetComponent<VideoPlayer>().time;
        
        if(beatMap.ContainsKey(time) && time > lastTime) {
            lastTime =  time;
            
            GameObject thisKey = Instantiate(beatMap[time], new Vector3(100, 0, 0), Quaternion.identity);

            thisKey.transform.SetParent (GameObject.Find("BeatCanvas").transform, false);
        }
    }
    
}
