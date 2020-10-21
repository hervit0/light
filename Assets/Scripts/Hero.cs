using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;

    void FixedUpdate() {
        float x = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(x * speed, rigidbody.velocity.y);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
