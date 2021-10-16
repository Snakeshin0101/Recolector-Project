using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public static int CoinsCount = 0;
    public int CoinValue = 1;

    // Se llama cuando empieza el juego
    void Start()
    {

        Coin.CoinsCount += CoinValue;
        Debug.Log(CoinsCount);

    }

    // Se llama cuando se destruye un objeto
    
    void OnDestroy()
    {

        Coin.CoinsCount -= CoinValue;

        if (Coin.CoinsCount <= 0)
        {
            Debug.Log(CoinsCount);
        }

    }

    void OnTriggerEnter(Collider Collider) {

        if (Collider.CompareTag ("Player"))
        {
            Destroy (gameObject);
        }

    }

}
