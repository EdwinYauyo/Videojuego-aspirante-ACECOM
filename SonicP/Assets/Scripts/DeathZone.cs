﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour {

    public GameObject PlayerSonic;
    public GameObject DeathText;
    public GameObject RespawnText;
    public Transform RespawnPosition;
    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(1.5f);
        
        DeathText.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        PlayerSonic.GetComponent<Transform>().position = RespawnPosition.position;
        PlayerSonic.SetActive(true);
        RespawnText.gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Sonic"))
        {
           col.gameObject.SetActive(false);
           DeathText.gameObject.SetActive(true);
            RespawnText.gameObject.SetActive(true);
            StartCoroutine(Respawn());



        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
