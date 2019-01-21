using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject BulletSpawn;
    public Transform bulletPoolTr;
    private int CurrentBulletIndex = 0;

    public void ButtonFire()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().volume = 0.3f;
        Rigidbody2D bulletRB = bulletPoolTr.GetChild(CurrentBulletIndex).GetComponent<Rigidbody2D>();
        bulletRB.gameObject.SetActive(true);
        bulletRB.position = BulletSpawn.transform.position + Vector3.right;
        bulletRB.velocity = Vector2.zero;
        bulletRB.AddForce(Vector2.right * 25, ForceMode2D.Impulse);
        CurrentBulletIndex++;
        if (CurrentBulletIndex >= bulletPoolTr.childCount)
        {
            CurrentBulletIndex = 0;
        }
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
