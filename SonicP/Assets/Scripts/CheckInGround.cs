using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInGround : MonoBehaviour
{

    private ControllerSonic PlayerSonic;
	// Use this for initialization
	void Start () {
        PlayerSonic = GetComponent<ControllerSonic>();

	}
	
    void OnCollisionStay2D(Collision2D col)
    {
        PlayerSonic.InGround = true;
        
    }
    void OnCollisionExit2D(Collision2D col)
    {
        PlayerSonic.InGround = false;

    }
}
