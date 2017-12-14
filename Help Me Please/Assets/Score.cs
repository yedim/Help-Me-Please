using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int currentScore;
    public Text scoreText;
    public Text resultScoreText;

    // Use this for initialization
    void Start()
    {
        currentScore = 0;
        resultScoreText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("" + currentScore);
        resultScoreText.text = scoreText.text;
    }
    public static void addScore()
    {
        currentScore += 10;
    }
}
