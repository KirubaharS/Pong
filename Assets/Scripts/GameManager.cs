using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, ScoreTextRight;

    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
            scorePlayer1++;
        if (id == 2)
            scorePlayer2++;

        UpdateScores();
    }

    private void UpdateScores()
    {
        scoreTextLeft.SetScore(scorePlayer1);
        ScoreTextRight.SetScore(scorePlayer2);
    }
}
