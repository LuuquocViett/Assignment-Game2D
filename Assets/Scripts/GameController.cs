using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text scoreText;
    public Text gameOverScoreText;
    public GameObject gameOverText;
    private int score = 0;
    public bool isGameOver = false;
    public AudioSource mainSound;
    public AudioSource dieSound;
    public AudioSource coinSound;
    public AudioSource jumpSound;
    public AudioSource killSound;
    public AudioSource nextSceneSound;
    private void Awake()
    {
        if(instance == null) {
            instance = this;
        }
        else if(instance ==this){
            Destroy(gameObject);
        }
    }
    public void check(bool gameOver)
    {
        if (gameOver == true) 
        {
            gameOverScoreText.text = "Your Score: " + this.score;
            gameOverText.SetActive(true);
            mainSound.Stop();
            dieSound.Play();
            this.isGameOver = true;
        }
        else
        {
            mainSound.Play();
        }
    }
    public void AddScore(int score)
    {

        this.score += score;
        scoreText.text = "SCORE: " + this.score;
    }

    public void soundCoin(bool check) {
        if (check) {
            coinSound.Play();
        }else {
            coinSound.Stop();
        }
    }
}
