/**
 * Class KeyMotionController
 * @author Slide Gurtiza <slide.gurtiza@gmail.com>
 * @package Prefab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMotionController : MonoBehaviour
{
    // TODO add public key character param and set the button text to that

    private float keySpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // FIXME get X-pos param from a public property
        transform.position = new Vector3 (10, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Remove object if it went out-of-frame
        if(transform.position.x < -10f) {
            Destroy(gameObject);
        }

        // TODO remove if key miss

        transform.position = new Vector3 (transform.position.x - (Time.deltaTime * keySpeed), transform.position.y, transform.position.z);
    }



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
