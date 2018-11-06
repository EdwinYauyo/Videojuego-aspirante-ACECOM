using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPositionExternal : MonoBehaviour {
    
    public GameObject enemy;
    public Transform ReaparitionPosition;

    public IEnumerator Respawn()
    {

       yield return new WaitForSeconds(3f);
       enemy.GetComponent<Transform>().position = ReaparitionPosition.position;
       enemy.SetActive(true);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sonic")
        {
            enemy.SetActive(false);

            StartCoroutine(Respawn());
        }
    }
}
