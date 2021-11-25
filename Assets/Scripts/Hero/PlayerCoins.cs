using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour{

    [SerializeField]
    Text textToShowCoins;

    int points = 0;

    void Start(){
        points = 0;
        ShowPoints();
    }

    public void AddPoints(int p) {
        points += p;
        ShowPoints();
    }

    void ShowPoints() {
        textToShowCoins.text = points.ToString();
    }



}
