using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeLeft = 20f;
    public Text countdownText;
    public GameObject gameover;
    public GameObject gameoverbutton;
    public Score score;
    private bool scoresave;
	// Use this for initialization
	void Start () {
        gameover.gameObject.SetActive(false);
        gameoverbutton.gameObject.SetActive(false);
        scoresave = false;
    }

    // Update is called once per frame
    void Update () {
        countdownText.text = ("" + timeLeft);

        if (timeLeft<=0)
        {
            // PlayerPrefs.SetInt("0", Score.currentScore);
            GameGrid.canPlay = false;
            if(scoresave==false)
            {
                InsertRank(Score.currentScore);
                countdownText.text = ("" + 0);
                timeLeft = 0;
                gameover.gameObject.SetActive(true);
                score.resultScoreText.gameObject.SetActive(true);
                gameoverbutton.gameObject.SetActive(true);
                scoresave = true;
            }

        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
    }

    void InsertRank(int score)
    {
        for (int i = 0; i < 5; i++)
        {
            if (Score.currentScore > PlayerPrefs.GetInt(i.ToString()))
            {
                for (int j = 4 - i; j > 0; j--)
                {
                    PlayerPrefs.SetInt(j.ToString(), PlayerPrefs.GetInt((j - 1).ToString()));
                    //currentScore가 1등 기준으로
                    //PlayerPrefs의 key값(j위치의 값 4(5등의 값))을 j-1위치의 값(4등의값)으로 바꾼다.

                }
                PlayerPrefs.SetInt(i.ToString(), Score.currentScore);
                break;
            }


        }
    }
}
