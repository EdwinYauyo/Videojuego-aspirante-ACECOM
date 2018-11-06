using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPosition : MonoBehaviour
{
    public GameObject enemy;
    public Transform ReaparitionPosition;

    public IEnumerator Respawn()
    {
       
        yield return new WaitForSeconds(3f);
       gameObject.GetComponent<Transform>().position = ReaparitionPosition.position;
       enemy.gameObject.SetActive(true);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sonic")
        {
            other.gameObject.SetActive(false);

            StartCoroutine(Respawn());
        }
    }
}
