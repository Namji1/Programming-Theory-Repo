using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    private int timeLeft;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI TimerText;

    public Button restartButton;

    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        timeLeft = 60;
        InvokeRepeating("Countdown", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        TimerText.text = "Time: " + timeLeft;
    }

    private void GameOver()
    {
        gameOver = true;
        GameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    private void Countdown()
    {
        if (timeLeft > 0)
        {
            timeLeft--;
        }
        else
        {
            GameOver();
        }
    }
}
