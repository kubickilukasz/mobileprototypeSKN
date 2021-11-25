using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour{

    [SerializeField]
    Text textToShowCoins;

    [SerializeField]
    Animator animatorTextEffect;

    [SerializeField]
    float speedEffect = 2f;

    int points = 0;

    void Start(){
        points = 0;
        animatorTextEffect.SetFloat("speed", 0);
        ShowPoints();
    }

    public void AddPoints(int p) {
        points += p;
        ShowPoints();
        ShowEffect();
    }

    void ShowPoints() {
        textToShowCoins.text = points.ToString();
    }

    void ShowEffect() {
        StopAllCoroutines();
        StartCoroutine(PlayEffect());
    }

    IEnumerator PlayEffect() {

        animatorTextEffect.SetFloat("speed", speedEffect);

        yield return new WaitForSeconds(1f);

        animatorTextEffect.SetFloat("speed", speedEffect / 2);

        yield return new WaitForSeconds(1f);

        animatorTextEffect.SetFloat("speed", 0f);
    }

}
