using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemyAparition : MonoBehaviour {
    public GameObject bigEnemy;

    void OnTrigger2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Sonic"))
        {
            bigEnemy.SetActive(true);
            
        }
    }
}
