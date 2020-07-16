using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour
{
    public Slider scoreBar;
    public Score playerScore;

    private void Start()
    {
        playerScore = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();
        scoreBar = GetComponent<Slider>();
        scoreBar.value = 0;
        scoreBar.maxValue = playerScore.maxScore;
    }

    public void SetScore(int hp)
    {
        scoreBar.value = hp;
    }
}