using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    public GameObject BulletSpawn;
    public Transform bulletPoolTr;
    public static int CurrentBulletIndex = 0;
    private float timer=1f;

    //Эксперимент
    private Transform player;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        FireToPlayer.target = new Vector2(player.position.x, player.position.y);
    }

    

    // Update is called once per frame
    void Update ()
    {
        Rigidbody2D bulletRB = bulletPoolTr.GetChild(CurrentBulletIndex).GetComponent<Rigidbody2D>();
        bulletRB.gameObject.SetActive(true);
        bulletRB.position = BulletSpawn.transform.position;
        CurrentBulletIndex++;
        if (CurrentBulletIndex >= bulletPoolTr.childCount)
        {
            CurrentBulletIndex = 0;
        }
    }
}
