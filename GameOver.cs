using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public Text textScore;
    public bool paused;

    // Use this for initialization
    void Start ()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
	
    private void GameOverFunc()
    {
        gameOver.SetActive(true);
        gameObject.SetActive(false);
        textScore.text = "Score: " + ScoreController.Score;
        Time.timeScale = 0;
        paused = true;
    }

    private void GameOverFunc_2()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }

	// Update is called once per frame
	void Update ()
    {
		if (HealthController.Health==0)
        {
            GameOverFunc();
        }
        else if (HealthController.Health>0)
        {
            gameOver.SetActive(false);
        }
	}
}
