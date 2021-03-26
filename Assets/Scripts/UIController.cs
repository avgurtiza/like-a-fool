using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UIController : MonoBehaviour
{
    protected GameObject BakaMitaiVid;
    
    private Dictionary<double, string> beatMap;

    private double lastTime;

    public GameObject KeyPrefab;

    public UIController() {

        beatMap =  new Dictionary<double, string>();
        beatMap.Add(2.6d, "K");
        beatMap.Add(7.6d, "I");
        beatMap.Add(9d, "J");
        beatMap.Add(11d, "K");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("INSIDE UI CONTROLLER");   
        
        BakaMitaiVid = GameObject.FindWithTag("SongVid");
    }

    // Update is called once per frame
    void Update()
    {
        var time = BakaMitaiVid.GetComponent<VideoPlayer>().time;

        if(beatMap.ContainsKey(time) && time > lastTime) {
            lastTime =  time;
            Debug.Log(beatMap[time]);
            GameObject thisKey = Instantiate(KeyPrefab, new Vector3(357, 0, 0), Quaternion.identity);

            thisKey.transform.SetParent (GameObject.Find("BeatCanvas").transform, false);

        }
    }
    
}
