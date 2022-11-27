using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI distText;
    public GameObject scoreKeeper;

    public int score;
    public float timer;
    public float dist;

    public void AddTime(float toAdd)
    {
        timer += toAdd;
        timerText.text = timer.ToString("0.0");
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
        scoreText.text = score.ToString();
    }

    public void AddDist(float toAdd)
    {
        dist += toAdd;
        distText.text = dist.ToString("0.0") + "m";
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("0.0");
        if (timer <= 0)
        {
            scoreKeeper.GetComponent<ScoreContainerScript>().EndLevel();
        }
    }

}
