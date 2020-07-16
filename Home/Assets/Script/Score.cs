using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int curScore = 0;
    public int maxScore = 10000;

    //for actions
    public int currentChange = 0;

    public ScoreBar scoreBar;

    // Start is called before the first frame update
    void Start()
    {
        curScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        change(currentChange);
        currentChange = 0;
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

    //set change in score
    public void setChange(int setTo) 
    {
        currentChange = setTo;
    }

    //add to the score
    public void addScore ( int score )
    {
        curScore += score;

        scoreBar.SetScore( curScore );
    }

    //change score
    public void change( int value )
    {
        curScore += value;

        scoreBar.SetScore( curScore );
    }
}