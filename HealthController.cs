using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Text textHealth;
    public static int Health = 100;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        textHealth.text = "Health: " + Health;
        if (Health > 100)
            Health = 100;
        if (Health < 0)
            Health = 0;
	}
}
