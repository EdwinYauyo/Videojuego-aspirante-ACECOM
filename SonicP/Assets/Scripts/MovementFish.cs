using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFish : MonoBehaviour
{
    
    public float respawnDelay = 5f;
    public float JumpFish = 6.5f;

    private Rigidbody2D rb2d;
    private Vector3 start;
    
    
    public bool JumpF = true;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        start = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
        
    {
        JumpF = true;
        if (JumpF)
        {

            rb2d.AddForce(Vector2.up * JumpFish, ForceMode2D.Impulse);
            rb2d.isKinematic = false;
            JumpF = false;
        }
        


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("LimitFishUp"))
        {
            JumpFish = 0f;
            transform.localScale = new Vector3(1f, -1f, 1f);
        }
        if (col.CompareTag("LimitFishDown"))
        {
            Invoke("Respawn", respawnDelay);
        }
        
    }
    void Respawn()
    {
        transform.position = start;
        rb2d.velocity = Vector3.zero;
        JumpFish = 1.2f;
        transform.localScale = new Vector3(1f, 1f, 1f);

    }
}
