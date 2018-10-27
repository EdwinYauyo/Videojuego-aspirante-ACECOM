using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public Sprite block1;
    public Sprite block2;
    private SpriteRenderer checkPointSpriteRenderer;
    public bool checkPointReached;

	// Use this for initialization
	void Start () {
        checkPointSpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Sonic"){
            checkPointSpriteRenderer.sprite = block2;
            checkPointReached = true;
        }
    }
}
