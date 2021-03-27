/**
 * Class WallController
 * @author Slide Gurtiza <slide.gurtiza@gmail.com>
 * @package Karaoke\BeatCanvas
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Wall created!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FIXME This does not work.  At all.
    void OnCollisionEnter2D(Collision collisionInfo)
    {
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
    }
 
    void OnCollisionStay2D(Collision collisionInfo)
    {
        Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
    }
    
    void OnCollisionExit2D(Collision collisionInfo)
    {
        Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }
}
