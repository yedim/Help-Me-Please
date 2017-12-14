using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Title : MonoBehaviour {

    public GameObject g;
    public GameObject g2;
    public GameObject q;
    public GameObject q2;
    public GameObject q3;
    // Use this for initialization
    void Start () {
        g.gameObject.SetActive(false);
        g2.gameObject.SetActive(false);

        q.gameObject.SetActive(false);
        q2.gameObject.SetActive(false);
        q3.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ClickExplain()
    {
        SceneManager.LoadScene(2);
    }

    public void ClickExplainButton()
    {
        g.gameObject.SetActive(true);
        g2.gameObject.SetActive(true);
    }

    public void OnClickRank()
    {
        q.gameObject.SetActive(true);
        q2.gameObject.SetActive(true);
        q3.gameObject.SetActive(true);

    }
    public void OnClickRankClose()
    {
        q.gameObject.SetActive(false);
        q2.gameObject.SetActive(false);
        q3.gameObject.SetActive(false);

    }

    public void DeleteClick()
    {
        g.gameObject.SetActive(false);
        g2.gameObject.SetActive(false);
    }

    public void DeleteClickRank()
    {
        q.gameObject.SetActive(false);
        q2.gameObject.SetActive(false);
        q3.gameObject.SetActive(false);

    }
}
