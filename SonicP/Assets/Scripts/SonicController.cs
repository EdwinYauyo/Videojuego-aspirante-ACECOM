using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonicController : MonoBehaviour
{

   
    public GameObject _refSonic;
    public CoinT _refCoinGame;
    private string cadCoins;
   
    private void Start()
    {
        cadCoins = ("Points: ");
    }

    private void Update()
    
    {
        
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
           
            _refSonic.GetComponent<Rigidbody2D>().velocity = new Vector2(4, 0);
            Debug.Log("Move right");
           
        }

        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            _refSonic.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Debug.Log("Stop right");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _refSonic.GetComponent<Rigidbody2D>().velocity = new Vector2(-4, 0);
            Debug.Log("Move left");
        }

        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _refSonic.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Debug.Log("Stop left");
        }
        else
            Debug.Log("None");

        if (Input.GetKeyDown(KeyCode.Space))
        {

           
              _refSonic.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
                Debug.Log("Move up");
            
        }

        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            _refCoinGame.points += 1;
            _refCoinGame.pointsText.text = cadCoins + _refCoinGame.points;
        }
    }
}
    
