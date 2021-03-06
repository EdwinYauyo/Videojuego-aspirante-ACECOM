﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSonic : MonoBehaviour {

    public float maxSpeed = 5f;
    public float speed = 2f;
    public GameObject _refSonic;
    public CoinT _refCoinGame;
    public bool InGround;
    public float JumpSonic = 6.5f;

    public AudioClip CoinSound = null;
    public float volumen = 1f;
    protected Transform Position = null;

    public AudioClip DeadSound = null;
    public float volumen3 = 1f;
    protected Transform Position3 = null;


    private string cadCoins;
    private Rigidbody2D rb2d;
    private Animator anim;
    private bool JumpD;

    public Vector3 respownPoint;
    // Use this for initialization

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        cadCoins = ("Points: ");
        Position = transform;
    }

    void Update ()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("InGround", InGround);

        if (Input.GetKeyDown(KeyCode.UpArrow) && InGround)
        {
            JumpD = true;
        }
    }

    void FixedUpdate() {

        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right * speed * h);

        float limitspeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitspeed, rb2d.velocity.y);

        if(h> 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(h< -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        Debug.Log(rb2d.velocity.x);

        if (JumpD)
        {
            rb2d.AddForce(Vector2.up * JumpSonic, ForceMode2D.Impulse);
            JumpD = false;
        }
	}
    public GameObject Player;
    public GameObject Apar;
    public GameObject bigEnemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            _refCoinGame.points += 1;
            _refCoinGame.pointsText.text = cadCoins + _refCoinGame.points;
            AudioSource.PlayClipAtPoint(CoinSound, Position.position, volumen);
        }

        if (col.gameObject.CompareTag("FinalDoor"))
        {
            Apar.SetActive(true);
            Player.SetActive(false);
        }

        


        if (col.gameObject.CompareTag("Bandera"))
        {
            bigEnemy.SetActive(true);

        }
    



        if (col.tag == "FallDectector"){
            transform.position = respownPoint;
            if (DeadSound) AudioSource.PlayClipAtPoint(DeadSound, Position3.position, volumen3);
        }
        if (col.tag == "CheckPoint"){
            respownPoint = col.transform.position;
            
        }


    }

    
    public void EnemyJump()
    {
        JumpD = true;
    }
}
