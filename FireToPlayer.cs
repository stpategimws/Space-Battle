using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireToPlayer : MonoBehaviour
{
    public float speed;

    public static Vector2 target;
    public Vector2 target_2;
    private Transform bulletEnemy;
    private Transform player;

    private float timer = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            if (InvulnerabilityController.Invul==false)
            {
                HealthController.Health = HealthController.Health - (1 + ComplicationController.ComplicationScore);
            }
                //HealthController.Health -= 1;
        if (collision.tag=="EnemyBullet")
            target = new Vector2(player.position.x, player.position.y);
    }

    // Use this for initialization
    public void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update ()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        bulletEnemy = GameObject.FindGameObjectWithTag("BulletEnemy").transform;
        target_2 = new Vector2(bulletEnemy.position.x, bulletEnemy.position.y);
        if (target_2==target)
        {
            gameObject.SetActive(false);
        }
    }
}
