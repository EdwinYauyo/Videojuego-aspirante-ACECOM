using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparition : MonoBehaviour {
    public GameObject Apar;
	
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sonic"))
        {
            Apar.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
