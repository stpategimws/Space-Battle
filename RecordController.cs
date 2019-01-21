using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordController : MonoBehaviour
{
    public Text text;

    // Use this for initialization
    void Start ()
    {
        text.text = "Record: " + PlayerPrefs.GetInt("savescore").ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
