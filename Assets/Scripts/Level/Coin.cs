using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{

    [SerializeField]
    int points = 1;

    void OnTriggerEnter2D(Collider2D collision) {
        PlayerCoins playerCoins = collision.GetComponent<PlayerCoins>();
        if (playerCoins) {
            playerCoins.AddPoints(points);
            Destroy(gameObject);
        }

    }
}
