/**
 * Class BeatController
 * @author Slide Gurtiza <slide.gurtiza@gmail.com>
 * @package Karaoke\BeatCanvas
 */

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


    // Update is called once per frame
    void Update()
    {
        var time = BakaMitaiVid.GetComponent<VideoPlayer>().time;
        
        if(BeatMap.ContainsKey(time) && time > lastTime) {
            lastTime =  time;

            // FIXME Find a way to instantiate into a target canvas without having to transform
            // FIXME move x-pos param to a public property
            GameObject thisKey = Instantiate(BeatMap[time], new Vector3(100, 0, 0), Quaternion.identity);
            thisKey.transform.SetParent(GameObject.Find("BeatCanvas").transform, false);
        }
    }

    /**
    * Builds the beatmap array
    * @returns Dictionary
    */
    private Dictionary<double, GameObject> BuildBeatMap() {
        // TODO re-evaluate. Is dictionary the best choice for this?  
        // FIXME match times with song BPM
        var beatMap = new Dictionary<double, GameObject>();
        beatMap.Add(1.2d, KeyPrefabK);
        beatMap.Add(2.6d, KeyPrefabI);
        beatMap.Add(7.6d, KeyPrefabI);
        beatMap.Add(9d, KeyPrefabJ);
        beatMap.Add(11d, KeyPrefabK);

        beatMap.Add(12d, KeyPrefabJ);
        beatMap.Add(13.3d, KeyPrefabK);

        beatMap.Add(15d, KeyPrefabI);
        beatMap.Add(15.3d, KeyPrefabK);
        beatMap.Add(15.6d, KeyPrefabJ);

        beatMap.Add(16.2d, KeyPrefabK);
        beatMap.Add(17.6d, KeyPrefabI);
        beatMap.Add(18.6d, KeyPrefabI);
        beatMap.Add(19d, KeyPrefabJ);
        beatMap.Add(19.6d, KeyPrefabK);

        beatMap.Add(22d, KeyPrefabI);
        beatMap.Add(23.3d, KeyPrefabK);
        beatMap.Add(24.6d, KeyPrefabJ);

        beatMap.Add(32.3d, KeyPrefabK);
        return beatMap;
    }
    
}
