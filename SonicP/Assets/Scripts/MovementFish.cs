using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFish : MonoBehaviour
{

    public float JumpFish = 6.5f;
    private Rigidbody2D rb2d;
    public float maxSpeed = 5f;
    private float h;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
        
    {
        rb2d.AddForce(Vector2.up * JumpFish, ForceMode2D.Impulse);
        

    }

}
