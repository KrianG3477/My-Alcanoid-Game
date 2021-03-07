using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text heartBonusText;
    [SerializeField]
    private Text finalScoreText;

    [SerializeField]
    private PlayerHeartEvents playerHeart;

    // 보너스 및 최종점수
    private uint bonusScore;
    private uint finalScore;

    private uint score = 0;

    public uint Score { get => score; set => score = value; }
    public uint FinalScore
    {
        get
        {
            return finalScore;
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GetBlockScore()
    {
        score += 300;
    }

    public void GetTotalScore()
    {
        bonusScore = (uint)(playerHeart.Heart * 10000);
        heartBonusText.text = bonusScore.ToString();

        finalScore = bonusScore + score;
        finalScoreText.text = finalScore.ToString();
    }
}
