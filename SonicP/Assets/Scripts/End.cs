using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject Player;
    public GameObject Apar;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sonic"))
        {
            Apar.SetActive(true);
       
        }

        if (gameObject.CompareTag("Sonic"))
        {

            Player.SetActive(false);

        }
    }
}
