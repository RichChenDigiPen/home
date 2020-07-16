using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int curScore = 0;
    public int maxScore = 10000;

    public ScoreBar scoreBar;

    // Start is called before the first frame update
    void Start()
    {
        curScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            addScore(100);
        }
        if(curScore >= maxScore) 
        {
            Debug.Log("WIN CONDITION");
            //you win
        }
    }

    public void addScore ( int score )
    {
        curScore += score;

        scoreBar.SetScore( curScore );
    }
}