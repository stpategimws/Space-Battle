using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveController : MonoBehaviour
{
    private float timer = 0.5f;

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.activeSelf)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                gameObject.SetActive(false);
                timer = 0.5f;
            }
        }
	}
}
