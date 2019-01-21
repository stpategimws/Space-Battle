using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAndKitController : MonoBehaviour
{
    public GameObject Spawn;
    Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if(HealthController.Health!=100)
            {
                HealthController.Health += 10;
                gameObject.SetActive(false);
                gameObject.transform.position = Spawn.transform.position;
            }
        }
    }


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();	
	}

    // Update is called once per frame
    void Update ()
    {
	    	
	}
}
