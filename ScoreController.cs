using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text textScore;
    public static int Score = 0;
    public static int record;

    // Use this for initialization
    void Start ()
    {
        Score = 0;
        textScore.text = "Score: " + Score;
	}
	
	// Update is called once per frame
	void Update ()
    {
        textScore.text = "Score: " + Score;

        //Сохранение рекорда
        if (Score > record)
        {
            record = Score;
            PlayerPrefs.SetInt("savescore", record);
            PlayerPrefs.Save();
        }
        record = PlayerPrefs.GetInt("savescore");
    }
}
