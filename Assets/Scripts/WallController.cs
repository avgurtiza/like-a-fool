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
        // KeyCollision = GetComponent<C>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Collision enter" + gameObject.name);
        // Debug.Log("Detected collision between " + gameObject.name);
        Debug.Log(collision.name);
    } 
    private void OnTriggerStay2D( )
    {
        // Debug.Log(gameObject.name + " and " + KeyCollider.name + " are still colliding");
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Debug.Log("Collision exit"+ gameObject.name);
        Debug.Log(collision.name);
        // Debug.Log(gameObject.name + " and " + KeyCollider.name + " are no longer colliding");
    }
}
