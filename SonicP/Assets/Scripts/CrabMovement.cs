﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabMovement : MonoBehaviour {

    public float maxSpeed = 1f;
    public float speed = 1f;




    private PolygonCollider2D pc2d;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        pc2d = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        rb2d.AddForce(Vector2.right * speed);
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            speed = -speed;
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

        if (speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (speed < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sonic"))
        {
            pc2d.isTrigger = true;
           
        }
    }

   

   

   
}
