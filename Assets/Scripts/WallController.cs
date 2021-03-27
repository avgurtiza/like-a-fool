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
