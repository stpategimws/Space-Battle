using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject PanelSetting;
	
    public void StartGames()
    {
        HealthController.Health = 100;
        ComplicationController.ComplicationScore = 0;
        SceneManager.LoadScene(1);
    }

    public void OpenPanelSetting()
    {
        PanelSetting.SetActive(true);
    }

    public void ClosedPanelSetting()
    {
        PanelSetting.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
