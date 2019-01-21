using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalController : MonoBehaviour
{
    public Transform MedicalSpawn;
    public GameObject Spawn;
    private int CurrentBulletIndex = 0;
    public float timer = 6;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Rigidbody2D bulletRB = MedicalSpawn.GetChild(CurrentBulletIndex).GetComponent<Rigidbody2D>();
            bulletRB.gameObject.SetActive(true);
            bulletRB.position = MedicalSpawn.transform.position - Vector3.left;
            bulletRB.velocity = Vector2.zero;
            bulletRB.AddForce(Vector2.left * 5, ForceMode2D.Impulse);
            CurrentBulletIndex++;
            if (CurrentBulletIndex >= MedicalSpawn.childCount)
            {
                CurrentBulletIndex = 0;
                timer = 6;
            }
        }
    }
}
