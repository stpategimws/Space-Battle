using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplicationController : MonoBehaviour
{
    public static int ComplicationScore = 0;
    private float timer = 0;
	
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer>=20)
        {
            ++ComplicationScore;
            timer = 0;
            return;
        }
	}
}
