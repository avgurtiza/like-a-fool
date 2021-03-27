using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMotionController : MonoBehaviour
{
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

        transform.position = new Vector3 (transform.position.x - (Time.deltaTime * keySpeed), transform.position.y, transform.position.z);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
    }
 
    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
    }
    
    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }
}
