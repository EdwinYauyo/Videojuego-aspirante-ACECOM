using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint2 : MonoBehaviour {

    public Transform Block1;
    public Transform Block2;
    public Transform Player;

    void OnTriggerEnter2D(Collider2D cin)
    {
        if (cin.CompareTag("block1"))
        {
            Player.position = Block1.position;
        }
        if (cin.CompareTag("block2"))
        {
            Player.position = Block1.position;
        }
    }
}
