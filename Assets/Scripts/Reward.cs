using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public int coinValue = 0;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            GameController.instance.AddScore(coinValue);
            GameController.instance.soundCoin(true);
            Destroy(gameObject);
        }else {
            GameController.instance.soundCoin(false);
        }
    }
}
