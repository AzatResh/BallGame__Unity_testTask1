using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Difficulty : MonoBehaviour
{
    [SerializeField] private UIManager uiScore;
    
    [SerializeField] private int minScoreDifficulty = 0;
    [SerializeField] private int maxScoreDifficulty = 20;
    private int currentScore;

    public float GetDifficulty(){
        if(currentScore<minScoreDifficulty) return 0;
        else if(currentScore<=maxScoreDifficulty) return (float)currentScore/maxScoreDifficulty;
        else return 1;
    }

    private void Start() {
        BallBody.AddScore+=this.ScorePlus;
    }

    public void ScorePlus(){
        currentScore++;
        uiScore.UpdateScore(currentScore);
    }
}
