using UnityEngine;

public class PlayerExample : MonoBehaviour {

    private float moveSpeed=3;
    public Joystick joystick;

    void Start()
    {
          
    }

    void Update () 
	{
        if (FixedJoystick.T==false)
        {
            moveSpeed = 3;
        }
        else if (FixedJoystick.T==true)
        {
            if(moveSpeed<=15)
                moveSpeed += 0.05f;
        }

        Vector2 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);

        Vector2 moveVector2 = (transform.up * joystick.Vertical + transform.forward * joystick.Horizontal).normalized;
        transform.Translate(moveVector2 * moveSpeed * Time.deltaTime);

        /*
        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);

        Vector3 moveVector2 = (transform.up * joystick.Vertical + transform.forward * joystick.Horizontal).normalized;
        transform.Translate(moveVector2 * moveSpeed * Time.deltaTime);
        */


    }
}