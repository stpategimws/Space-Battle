using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalSpeed=0.2f;
    private float verticalImpulse=0.2f;

    private float speedX;
    private float speedY;


    public void FixedUpdate()
    {
        //Управление игроком на клавиатуре
        if (Input.GetKey(KeyCode.A))
        {
            speedX = -horizontalSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            speedX = horizontalSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            speedY = verticalImpulse;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            speedY = -verticalImpulse;
        }

        transform.Translate(speedX, 0, 0);
        speedX = 0;

        transform.Translate(0, speedY, 0);
        speedY = 0;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
