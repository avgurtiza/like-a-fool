/**
 * Class WallController
 * @author Slide Gurtiza <slide.gurtiza@gmail.com>
 * @package Karaoke\BeatCanvas
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    private BeatController BeatController;

    void Start()
    {
        GameObject BeatMap = GameObject.Find("BeatMap");
        BeatController = BeatMap.GetComponent<BeatController>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision.name.Substring(9,1));
        BeatController.currentBeat = collision.name.Substring(9,1);
    } 
    private void OnTriggerStay2D( )
    {
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Debug.Log(collision.name.Substring(9,1));
        BeatController.currentBeat = null;
    }
}
