using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMotionController : MonoBehaviour
{
    private float keyXPosition;
    public float keySpeed = 50f;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("KEY HAPPENED!");
        keyXPosition = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        keySpeed = Time.deltaTime;
        transform.Translate(Vector2.left * keySpeed);
    }
}
