using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BeatController : MonoBehaviour
{
    protected GameObject BakaMitaiVid;
    
    private Dictionary<double, GameObject> BeatMap;

    private double lastTime;

    public string TextMe;
    

    // FIXME use a single prefab class and pass params (key-letter, injections)
    public GameObject KeyPrefabI;
    public GameObject KeyPrefabJ;
    public GameObject KeyPrefabK;
    public GameObject KeyPrefabL;


    // Start is called before the first frame update
    void Start()
    {
        BeatMap =  BuildBeatMap();
        
        // TODO evaluate Find Vs FindWithTag
        BakaMitaiVid = GameObject.FindWithTag("SongVid");
    }

    private Dictionary<double, GameObject> BuildBeatMap() {
        // TODO re-evaluate. Is dictionary the best choice for this?  
        var beatMap = new Dictionary<double, GameObject>();
        beatMap.Add(1.2d, KeyPrefabK);
        beatMap.Add(2.6d, KeyPrefabI);
        beatMap.Add(7.6d, KeyPrefabI);
        beatMap.Add(9d, KeyPrefabJ);
        beatMap.Add(11d, KeyPrefabK);

        return beatMap;
    }

    // Update is called once per frame
    void Update()
    {
        var time = BakaMitaiVid.GetComponent<VideoPlayer>().time;
        
        if(BeatMap.ContainsKey(time) && time > lastTime) {
            lastTime =  time;
            
            GameObject thisKey = Instantiate(BeatMap[time], new Vector3(100, 0, 0), Quaternion.identity);

            thisKey.transform.SetParent (GameObject.Find("BeatCanvas").transform, false);
        }
    }
    
}
