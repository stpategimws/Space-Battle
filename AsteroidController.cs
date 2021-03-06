﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public Transform AsteroidSpawn;
    public GameObject Spawn;
    public GameObject Explosion;
    private int CurrentBulletIndex = 0;
    public float timer = 2;
    public int Speed;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.SetActive(false);
            Explosion.transform.position = gameObject.transform.position;
            Explosion.SetActive(true);
            gameObject.transform.position = Spawn.transform.position;
            if (InvulnerabilityController.Invul==false)
            {
                HealthController.Health = HealthController.Health - (10 + ComplicationController.ComplicationScore);
            }
                
        }
        if (collision.tag == "Bullet")
        {
            gameObject.SetActive(false);
            Explosion.transform.position = gameObject.transform.position;
            Explosion.SetActive(true);
            gameObject.transform.position = Spawn.transform.position;
            ScoreController.Score++;
        }

    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            Rigidbody2D bulletRB = AsteroidSpawn.GetChild(CurrentBulletIndex).GetComponent<Rigidbody2D>();
            bulletRB.gameObject.SetActive(true);
            bulletRB.position = Spawn.transform.position - Vector3.left;
            bulletRB.velocity = Vector2.zero;
            bulletRB.AddForce(Vector2.left * Speed, ForceMode2D.Impulse);
            CurrentBulletIndex++;
            if (CurrentBulletIndex >= AsteroidSpawn.childCount)
            {
                CurrentBulletIndex = 0;
                timer = 2;
            }
        }
        
    }
}
