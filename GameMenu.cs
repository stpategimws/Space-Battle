using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject Panel;
    public bool paused;

    public void OpenPanel()
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
        paused = true;
    }

    public void ClosedPanel()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }

    public void NewGame()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;
        paused = false;
        AdvertisingController.Counter = 1;
        ScoreController.Score = 0;
        HealthController.Health = 100;
        ComplicationController.ComplicationScore = 0;
        SceneManager.LoadScene(1);
    }

    public void ExitMainMenu()
    {
        Time.timeScale = 1;
        paused = false;
        AdvertisingController.Counter = 1;
        SceneManager.LoadScene(0);
    }
	
    // Use this for initialization
	void Start ()
    {
        gameOver.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
