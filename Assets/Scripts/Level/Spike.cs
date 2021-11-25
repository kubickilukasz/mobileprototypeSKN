using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour{

    void OnTriggerEnter2D(Collider2D collision) {
        PlayerCoins playerCoins = collision.GetComponent<PlayerCoins>();
        if (playerCoins) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

}
