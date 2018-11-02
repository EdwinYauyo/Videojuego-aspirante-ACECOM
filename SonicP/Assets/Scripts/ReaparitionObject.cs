using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaparitionObject : MonoBehaviour {

    
    public float respawnDelay = 5f;

    private Rigidbody2D rb2d;
    private Collider2D pc2d;
    private Vector3 start;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pc2d = GetComponent<Collider2D>();
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("FallDectector"))
        {
           
            Invoke("Respawn", respawnDelay);
        }
    }

    
    void Respawn()
    {
        transform.position = start;
        rb2d.velocity = Vector3.zero;
        
    }
}
