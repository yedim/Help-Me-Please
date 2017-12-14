using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over: MonoBehaviour {


    // Use this for initialization
    void Start () {
        //PlayerPrefs.SetInt("0", Score.currentScore);
       // InsertRank(Score.currentScore);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Click()
    {
        SceneManager.LoadScene(0);
    }

    void InsertRank(int score)
    {
         for(int i=0; i < 5; i++)
        {
            if(Score.currentScore >PlayerPrefs.GetInt(i.ToString()))
            {
                for(int j=4-i; j>0; j--)
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
