using System.Net.Mime;
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
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BeatController : MonoBehaviour
{
    protected GameObject BakaMitaiVid;

    protected GameObject BeatCanvas;
    
    private KaraokeControls karaokeControls;

    private Dictionary<double, GameObject> BeatMap;

    private double lastTime;

    public string currentBeat;
    
    private bool debouncing = false;

    private string lastBeatPress;

    // TODO use a single prefab class and pass params (key-letter, injections)
    public GameObject KeyPrefabI;
    public GameObject KeyPrefabJ;
    public GameObject KeyPrefabK;
    public GameObject KeyPrefabL;

    private int score = 0;

    public GameObject ScoreDisplay;

    private void Awake() {
        karaokeControls = new KaraokeControls();
    }

    private void OnEnable() {
        karaokeControls.Enable();
    }
    
    private void OnDisable() {
        karaokeControls.Disable();
    }

    void Start()
    {
        BeatMap =  BuildBeatMap();
        
        // TODO evaluate Find Vs FindWithTag
        BakaMitaiVid = GameObject.FindWithTag("SongVid");
        BeatCanvas = GameObject.Find("BeatCanvas");
        ScoreDisplay = GameObject.Find("ScoreDisplay");
    }

    void Update()
    {
        var time = BakaMitaiVid.GetComponent<VideoPlayer>().time;
        
        if(BeatMap.ContainsKey(time) && time > lastTime) {
            lastTime =  time;

            // TODO Find a way to instantiate into a target canvas without having to transform
            // TODO move x-pos param to a public property
            var thisBeat = BeatMap[time];
            GameObject thisKey = Instantiate(thisBeat, new Vector3(100, thisBeat.transform.position.y, 0), Quaternion.identity);
            thisKey.transform.SetParent(BeatCanvas.transform, false);
        }

        ScoreDisplay.GetComponent<Text>().text = score.ToString();

        if(currentBeat == null) {
            debouncing = false;
        }
    }

    // TODO I'm sure unity has it's own debouncing helpers
    public void OnTriangle(InputValue input) {
        if(currentBeat == "I" && !debouncing) {
            score++;
            debouncing = true;
        }
    }

    public void OnSquare(InputValue input) {
        if(currentBeat == "J" && !debouncing) {
            score++;
            debouncing = true;
        }
    }

    public void OnCross(InputValue input) {
        if(currentBeat == "K" && !debouncing) {
            score++;
            debouncing = true;
        }
    }

    public void OnCircle(InputValue input) {
        if(currentBeat == "L" && !debouncing) {
            score++;
            debouncing = true;
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
